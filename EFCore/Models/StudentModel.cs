using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreVsDapper.EFCore.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("TeacherId")]
        public int TeacherId { get; set; }
        public virtual TeacherModel Teacher { get; set; }

    }
}
