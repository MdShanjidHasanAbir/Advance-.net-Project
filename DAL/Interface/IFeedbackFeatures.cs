using DAL.Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IFeedbackFeatures
    {
        List<Feedback> SearchByTitle(string title);
        List<Feedback> SearchByCatagory(string catagory);

        //List<Feedback> AnnonymousFeedback(string name);
        
        
    }
}
