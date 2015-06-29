using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pro.Models;
namespace pro.Models
{
    public class log :Ilogin
    {
        public bool validate(admin ob)
        {
            using (Database1Entities obj = new Database1Entities())
            {
                var data = (from x in obj.admins
                            select x).ToList();
                foreach (var info in data)
                {
                    if (info.email == ob.email && info.password == ob.password)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
    }
}                                    