using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FeedbackDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }
        public DateTime Date { get; set; }
      
        public string FeedBackBy { get; set; }
        
        public int TeacherId { get; set; }
       
    }
}
