using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TeacherFeedbackDTO : TeacherDTO
    {
        public List<FeedbackDTO> Feedbacks { get; set; }
        public TeacherFeedbackDTO() { 
         Feedbacks= new List<FeedbackDTO>();
        }
    }
}
