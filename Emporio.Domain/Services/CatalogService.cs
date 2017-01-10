using Emporio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Emporio.Domain.Services
{
    public class CatalogService
    {
        public static Catalog Catalog = new Catalog();

        public static void InitializeCatalog()
        {
            Catalog.Add(new CatalogItem("Milk", "Dairy", null));
            Catalog.Add(new Entities.CatalogItem("Ice Scream", "Dairy", null));
            Catalog.Add(new CatalogItem("Light Bulbs", "Household", null));
        }

        
    }
}
