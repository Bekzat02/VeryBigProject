using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Articul { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Item item)
            {
                return Id == item.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
