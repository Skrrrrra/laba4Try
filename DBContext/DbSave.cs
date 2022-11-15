using laba4Try.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4Try.DBContext
{
    class DbSave
    {
        private static AppContext db;
        public DbSave(AppContext context)
        {
            db = context;
        }

        public static void SaveFirstTable(firstTable first)
        {
            db.FirstTable.Add(first);
            db.SaveChanges();
        }
        //public void SaveSecondstTable(SecondTable second)
        //{
        //    db.SecondTable.Add(second);
        //    db.SaveChanges();
        //}


    }
}
