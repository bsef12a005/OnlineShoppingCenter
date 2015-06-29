using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pro.Models
{
    public class update:Iupdate
    {
        public void update1(product obj)
        {
            using (Database1Entities db = new Database1Entities())
            {
                product product2=db.products.Find(obj.Id);
                product2.pName = obj.pName;
                product2.category = obj.category;
                product2.price = obj.price;
                product2.description = obj.description;
                product2.image = obj.image;
                db.SaveChanges();
                
            }
        }
    }
}