namespace EFCoreVsDapper.Dapper.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }

        public List<StudentModel> Students { get; set; } = new();
    }
}
