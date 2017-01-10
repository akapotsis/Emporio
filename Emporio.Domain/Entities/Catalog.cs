using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporio.Domain.Entities
{
    public class Catalog
    {
        public Catalog()
        {
            _items = new List<CatalogItem>();
        }
        private List<CatalogItem> _items { get; }

        public void Add(CatalogItem item)
        {
            bool exists = false;
            foreach (CatalogItem i in _items)
            {
                if (i.Name.Equals(item.Name))
                {
                    exists = true;
                }
            }

            if(!exists)
            {
                _items.Add(item);
            }

            // ToDo: Should we throw an exception if item exists?
        }

        public CatalogItem[] Items
        {
            get { return _items.ToArray(); }
        }
    }
}
