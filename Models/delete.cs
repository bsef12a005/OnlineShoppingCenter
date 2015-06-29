using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace pro.Models
{
    public class delete:Idelete
    {
        public void delete1(product obj)
        {
            using (Database1Entities db = new Database1Entities())
            {
                var data = db.products.Find(obj.Id);
                db.products.Remove(data);
                
                db.SaveChanges();

            }
        }
    }
}