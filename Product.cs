using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Basics
{
    //ORM - Table Users
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return Name + " " + Price + "$" + " ( " + Id + " ) ";
        }
    }
}
