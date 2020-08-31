using System;
using System.Linq;
namespace _0831dbtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new mylessondbContext();
            var ret = from c in db.ManagerTable
                      select c;

            foreach (var item in ret)
            {
                Console.WriteLine($"{item.Mid} - {item.Mname} - {item.Mphone}- {item.Mcountry} ");
            }
        }
    }
}
       
