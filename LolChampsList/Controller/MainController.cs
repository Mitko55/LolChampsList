using LolChampsList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolChampsList.Controller
{
    class MainController
    {
        public List<LolChamp> GetAllChamps()
        {
            using (LolChampsDBEntities db = new LolChampsDBEntities())
            {
                return db.LolChamps.ToList();
            }
        }
    }
}
