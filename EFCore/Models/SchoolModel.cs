using System.ComponentModel.DataAnnotations;

namespace EFCoreVsDapper.EFCore.Models
{
    public class SchoolModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TeacherModel> Teachers { get; set; }
    }
}
