using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporio.Domain.Entities
{
    public class ShoppingItem
    {
        public ShoppingItem(string name, bool isFavorite)
        {
            Name = name;
            Count = 1;
            IsFavorite = isFavorite;
        }
        public string Name { get; set; }
        public int Count { get; set; }
        public bool IsFavorite { get; set; }
    }
}
