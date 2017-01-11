using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporio.Domain.Entities
{
    public class ShoppingList
    {

        public ShoppingList()
        {
            _items = new List<ShoppingItem>();
        }
        public string Name { get; set; }
        private List<ShoppingItem> _items { get; }
        
        public void Add(ShoppingItem item)
        {
            bool exists = false;

            foreach (ShoppingItem s in _items)
            {
                if (s.Name.Equals(item.Name))
                {
                    s.Count++;
                    exists = true;
                }
            }

            if (exists == false)
            {
                _items.Add(item);
            }
        }

        public void Add(CatalogItem item)
        {
            Add(new ShoppingItem(item.Name, false));  
        }

        public void Add(RecipeItem item)
        {
            Add(new ShoppingItem(item.Name, false));
        }

        public void Add(Recipe recipe)
        {
            foreach (RecipeItem i in recipe.Items)
            {
                Add(i);
            } 
        }

        public void Remove(ShoppingItem item)
        {
            if(_items.Contains(item))
            {
                _items.Remove(item);
            }
        }

        public ShoppingItem[] Items 
        {
            get { return _items.ToArray(); }
        }
    }
}
