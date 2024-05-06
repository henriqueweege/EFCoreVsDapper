using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreVsDapper.EFCore.Models
{
    public class TeacherModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("SchoolId")]
        public int SchoolId { get; set; }
        public virtual SchoolModel School { get; set; }

        public virtual List<StudentModel> Students { get; set; }
    }
}
