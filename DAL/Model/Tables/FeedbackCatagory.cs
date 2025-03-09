using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Tables
{
    public class FeedbackCatagory
    {
        [Key]
        public int CId { get; set; }
        [Required]
        [StringLength(20)]
        public string CName { get; set; }
    }
}
