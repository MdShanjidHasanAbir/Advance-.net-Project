using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepo<CLASS,ID,RET>
    {
        RET Submit(CLASS obj);
        List<CLASS> Read();
        CLASS Read(ID id);
        RET Update(RET obj);
        bool DeleteFeedback(ID id);

    }
}
