using DAL.Model.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    internal class TFSContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FeedbackCatagory> FeedbackCatagories { get; set; }
    }
}
