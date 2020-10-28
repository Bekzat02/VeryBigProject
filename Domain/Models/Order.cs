using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
    public class Order
    {
        private readonly List<OrderItem> _items;

        public Order()
        {
            _items = new List<OrderItem>();
        }
        /*  public int Id { get; set; }
          public int CustomerId { get; set; }
          public DateTime OrderedDate { get; set; }*/
        public IReadOnlyList<OrderItem> Items => _items;

        public void AddItem(Item item)
        {
            var orderItem = GetByItem(item);
            if (orderItem is null)
            {
                orderItem = new OrderItem(item, this, 1);
                _items.Add(orderItem);
            }
            else
            {
                orderItem.Quantity++;
            }
        }

        public void RemoveItem(Item item)
        {
            var orderItem = GetByItem(item);
            if(orderItem is { })
            {
                RemoveItem(orderItem);
            }
        }

        public void RemoveItem(OrderItem orderItem)
        {
            var item = Items.FirstOrDefault(item => item.Equals(orderItem));
            if(item is { })
            {
                if(item.Quantity is 1)
                {
                    _items.Remove(item);
                }
                else
                {
                    item.Quantity--;
                }
            }
        }

        public OrderItem GetByItem(Item item)
        {
            return Items.FirstOrDefault(i => i.Item.Equals(item));
        }

        public decimal Price => Items.Sum(item => item.Price);


    }
}
