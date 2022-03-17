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

        public void CreateLolChamp(LolChamp lc)
        {
            using(LolChampsDBEntities lcdb = new LolChampsDBEntities())
            {
                lc.Id = lcdb.LolChamps.ToList().LastOrDefault().Id + 1;
                lcdb.LolChamps.Add(lc);
                lcdb.SaveChanges();
            }
        }
    }
}
