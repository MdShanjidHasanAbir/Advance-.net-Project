using DAL.Interface;
using DAL.Model.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Teacher,int,bool> TeacherData()
        {
            return new TeacherRepo();
        }
        public static IRepo<Feedback, int, Feedback> FeedbackData()
        {
            return new FeedbackRepo();

        }

        public static IFeedbackFeatures FeedbackFeatures()
        {
            return new FeedbackRepo();
        }
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
    }
}
