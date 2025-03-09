using DAL.Interface;
using DAL.Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FeedbackRepo : Repo, IRepo <Feedback, int, Feedback>,IFeedbackFeatures
    {
        public Feedback Submit(Feedback obj)
        {
            db.Feedbacks.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool DeleteFeedback(int id)
        {
            var ex = Read(id);
            db.Feedbacks.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Feedback> Read()
        {
            return db.Feedbacks.ToList();
           
        }

        public Feedback Read(int id)
        {
            return db.Feedbacks.Find(id);
        }


        public List<Feedback> SearchByCatagory(string catagory)
        {
            var result = from feedback in db.Feedbacks
                         where feedback.Catagory.Contains(catagory)
                         select feedback;

            return result.ToList();
        }
        public List<Feedback> SearchByTitle(string name)
        {
            return db.Feedbacks.Where(x => x.Title.Contains(name)).ToList();
        }

        public Feedback Update(Feedback obj)
        {
            throw new NotImplementedException();
        }

        /* public Feedback Update(Feedback obj)
         {
             var ex = Read(obj.Id);
             db.Entry(ex).CurrentValues.SetValues(obj);
             if (db.SaveChanges() > 0) return obj;
             return null;

         }*/
    }
}
