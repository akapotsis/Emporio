using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporio.Domain.Entities
{
    public class CatalogItem
    {
        public CatalogItem(string name, string category, string photo)
        {
            Name = name;
            Category = category;
            Photo = photo;
        }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Photo { get; set; }
    }
}
