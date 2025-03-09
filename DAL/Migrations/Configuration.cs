namespace DAL.Migrations
{
    using DAL.Model.Tables;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Model.TFSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Model.TFSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            /*for (int i = 0; i < 5; i++)
            {
                context.Users.AddOrUpdate(new Model.Tables.User
                {
                    Uname = "user-" + i,
                    Password=Guid.NewGuid().ToString().Substring(0,10),
                    Name= Guid.NewGuid().ToString().Substring(0,15),
                    Type="Student",
                });
                
            }*/
            /* Random random = new Random();
              for(int i = 0;i < 5;i++)
              {
                  context.Teachers.AddOrUpdate(new Model.Tables.Teacher
                  {
                      Tid=i,
                      TeacherName= Guid.NewGuid().ToString().Substring(0,15),
                      TeacherDept="CSE",
                      FeedbackBy= "User-"+random.Next(0,5),
                  });
              }

             for (int i = 0; i < 20; i++)
              {
                  context.Feedbacks.AddOrUpdate(new Model.Tables.Feedback
                  {
                      Id = i,
                      Title = Guid.NewGuid().ToString().Substring(0,15 ),
                      Description = Guid.NewGuid().ToString(),
                      Date=DateTime.Now,
                      FeedBackBy="User-"+ random.Next(0,5),
                      TeacherId=random.Next(0,5),
                  });
              }*/
            

        }
    }
}
