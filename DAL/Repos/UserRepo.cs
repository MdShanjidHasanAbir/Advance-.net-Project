using DAL.Interface;
using DAL.Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo<User, string, User>
    {
        public User Submit(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges()>0)return obj;
            return null;

        }

        public bool DeleteFeedback(string id)
        {
            var ex= Read(id);
            db.Users.Remove(ex);
            return db.SaveChanges() > 0;

        }

        public List<User> Read()
        {
            return db.Users.ToList();
        }

        public User Read(string id)
        {
           return db.Users.Find(id);
        }

        public User Update(User obj)
        {
            var ex= Read(obj.Uname);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj; 
            return null;
        }
    }
}
