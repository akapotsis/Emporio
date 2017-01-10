using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporio.Domain.Entities
{
    public class Recipe
    {
        public Recipe()
        {
            _items = new List<RecipeItem>();
        }

        public string Name { get; set; }

        private List<RecipeItem> _items { get; }

        public void Add(RecipeItem recipeItem)
        {
            bool exists = false;
            foreach (RecipeItem r in _items)
            {
                if (r.Name.Equals(recipeItem.Name))
                {
                    r.Count++;
                    exists = true;
                }
            }
            if (exists == false)
            {
                _items.Add(recipeItem);
            }
        }

        public void Add(CatalogItem item)
        {
            Add(new RecipeItem(item.Name, false));
        }

        public void Remove(RecipeItem item)
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
            }
        }

        public RecipeItem[] Items
        {
            get { return _items.ToArray(); }
        }
    }
}
