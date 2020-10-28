using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class OrderItem
    {
        private int _quantity;
        public OrderItem(Item item, Order order, int quantity)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            Order = order ?? throw new ArgumentNullException(nameof(order));
            Quantity = quantity;
        }
        public long Id { get; }
        public Item Item { get; }
        public Order Order { get; }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Quantity), "Item quantity can't be less than 1");
                }
                else
                {
                    _quantity = value;
                }
            }
        }
        public decimal Price => Item.Price * Quantity;

        public override bool Equals(object obj)
        {
            if(obj is OrderItem order)
            {
                return Id == order.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


    }
}
