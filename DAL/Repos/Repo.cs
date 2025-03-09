using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class Repo
    {
        internal TFSContext db;
        internal Repo()
        {
            db = new TFSContext();
        }
    }
}
