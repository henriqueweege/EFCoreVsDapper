using System.Data.SqlClient;
using Dapper;
using EFCoreVsDapper.Dapper.Models;
using BenchmarkDotNet.Attributes;

namespace EFCoreVsDapper.Dapper
{
    [ShortRunJob]
    [RankColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class DapperQueries
    {


        [Benchmark]
        public void LoadAll_With_Dapper_Using_QueryMultiple()
        {
            IEnumerable<SchoolModel> schools;
            IEnumerable<StudentModel> students;
            IEnumerable<TeacherModel> teachers;

            using (var connection = new SqlConnection(Settings.ConnectionString))
            {


                var query = @"
                SELECT * FROM Schools;
                SELECT * FROM Students;
                SELECT * FROM Teachers;
                ";

                var results = connection.QueryMultiple(query);

                schools = results.Read<SchoolModel>();
                students = results.Read<StudentModel>();
                teachers = results.Read<TeacherModel>();
            }




            foreach (var school in schools)
            {
                school.Teachers = teachers
                                    .Where(x => x.SchoolId == school.Id)
                                    .AsList();
            }

            foreach (var teacher in teachers)
            {
                teacher.Students = students
                                    .Where(x => x.TeacherId == teacher.Id)
                                    .AsList();
            }

            schools = schools.ToList();
            teachers = teachers.ToList();
            students = students.ToList();
        }


        [Benchmark]
        public void LoadAll_With_Dapper_Using_OneQuery()
        {
            using (var connection = new SqlConnection(Settings.ConnectionString))
            {


                var query = @"
                SELECT  
                    school.Id,
                    school.Name,
                    NULL AS Break1,
                    teacher.Id,
                    teacher.Name,
                    teacher.SchoolId,
                    NULL AS Break2,
                    student.Id ,
                    student.Name,
                    student.TeacherId      
                FROM
                    Schools school
                INNER JOIN 
                    Teachers teacher 
                ON
                    teacher.SchoolId = school.Id
                INNER JOIN 
                    Students student  
                ON
                    student.TeacherId = teacher.Id";


                var schoolHash = new Dictionary<int, SchoolModel>();
                var teacherHash = new Dictionary<int, TeacherModel>();
                var studentHash = new Dictionary<int, StudentModel>();

                var items = connection.Query<SchoolModel, TeacherModel, StudentModel, SchoolModel>
                (query,
                    (school, teacher, student) =>
                    {
                        if (schoolHash.TryGetValue(school.Id, out _))
                        {
                            school = schoolHash[school.Id];
                        }
                        else
                        {
                            schoolHash[school.Id] = school;
                        }
                        if (teacherHash.TryGetValue(teacher.Id, out _))
                        {
                            teacher = teacherHash[teacher.Id];
                        }
                        else
                        {
                            teacherHash[teacher.Id] = teacher;
                        }
                        if (studentHash.TryGetValue(student.Id, out _))
                        {
                            student = studentHash[student.Id];
                        }
                        else
                        {
                            studentHash[student.Id] = student;
                        }

                        var schoolOfTeacher = schoolHash.FirstOrDefault(x => x.Value.Id == teacher.SchoolId && !x.Value.Teachers.Any(x=>x.Id == teacher.Id)).Value;
                        if(schoolOfTeacher is not null)
                        {
                            schoolOfTeacher.Teachers.Add(teacher);
                        }

                        var teacherOfStudent = teacherHash.FirstOrDefault(x => x.Value.Id == student.TeacherId && !x.Value.Students.Any(x => x.Id == student.Id)).Value;
                        if (teacherOfStudent is not null)
                        {
                            teacherOfStudent.Students.Add(student);
                        }

                        return school;
                    }, splitOn: "Break1,Break2"
               );

                var schools = schoolHash.Values.ToList();
                var teachers = teacherHash.Values.ToList();
                var students = studentHash.Values.ToList();

            }
        }
    }
}
