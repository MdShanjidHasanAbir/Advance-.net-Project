using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TeacherDTO
    {
        public int Tid { get; set; }
        [Required]
        public string TeacherName { get; set; }
        [Required]
        public string TeacherDept { get; set; }
        [Required]
        public string FeedbackBy { get; set; }
      
    }
}
