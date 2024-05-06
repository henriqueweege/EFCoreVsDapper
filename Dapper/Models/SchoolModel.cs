namespace EFCoreVsDapper.Dapper.Models
{
    public class SchoolModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TeacherModel> Teachers { get; set; } = new();
    }
}
