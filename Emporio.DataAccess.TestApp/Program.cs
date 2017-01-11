using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporio.DataAccess.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmporioDemoEntities db = new EmporioDemoEntities();

            foreach(var item in db.CatalogItems)
            {
                Console.WriteLine(item.Name + " :  " + item.Category + "  :  " + item.CatalogItemId);
            }


            Console.ReadKey();
        }
    }
}
