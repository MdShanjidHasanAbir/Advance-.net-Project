using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Tables
{
    public class Teacher
    {
        [Key]
        public int Tid { get; set; }
        [Required]
        public string TeacherName { get; set; }
        [Required]
        public string TeacherDept { get; set; }
        [ForeignKey("User")]
        public string FeedbackBy { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public Teacher() { 

        Feedbacks = new List<Feedback>();

        }
        

    }
}
