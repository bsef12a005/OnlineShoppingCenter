using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 using pro.Models;
namespace pro.Models
{
    public class addItem :IaddItem
    {
        public void add(product obj)
        {
            using (Database1Entities db = new Database1Entities())
            {

                db.products.Add(obj);
                db.SaveChanges();
            }
        }
    }
}