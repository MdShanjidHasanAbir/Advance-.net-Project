using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Tables
{
    public class Feedback
    {
        public int Id { get; set; }
       
        public string Title { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("User")]
        public string FeedBackBy { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual User User { get; set; }
        
    
    }
}
