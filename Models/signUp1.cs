using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pro.Models;             
namespace pro.Models
{
    public class signUp1  :Interface1
    {
        public void save(admin obj)
        {
            using (Database1Entities db = new Database1Entities())
            {
                
                db.admins.Add(obj);
                db.SaveChanges();
            }
        }

    }
}