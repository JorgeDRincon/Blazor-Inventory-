using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInOuts(InputOutputEntity oInOuts)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInOuts);
                db.SaveChanges();
            }
        }

        public void UpdateInOuts(InputOutputEntity oInOuts)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInOuts);
                db.SaveChanges();
            }
        }
    }
}
