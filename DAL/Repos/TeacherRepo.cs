using DAL.Interface;
using DAL.Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TeacherRepo : Repo, IRepo<Teacher, int, bool>
    {
        public bool Submit(Teacher obj)
        {
            db.Teachers.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool DeleteFeedback(int id)
        {
            var ex = Read(id);
            db.Teachers.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Teacher> Read()
        {
            return db.Teachers.ToList();
        }

        public Teacher Read(int id)
        {
            return db.Teachers.Find(id);
        }

        public bool Update(bool obj)
        {
            throw new NotImplementedException();
        }
    }
}
