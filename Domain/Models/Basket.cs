using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
    public class Basket
    {
        private readonly List<BasketItem> _items;
        public Basket(int customerId)
        {
            _items = new List<BasketItem>();
            CustomerId = customerId;
        }
        public int CustomerId { get; }

        public IReadOnlyList<BasketItem> Items => _items;

        public void AddItem(int itemId)
        {
            AddItem(itemId, 1);
        }

        //OVERLOADED METHOD
        public void AddItem(int itemId, int quantity)
        {
            var item = _items.FirstOrDefault(item => item.ItemId == itemId);
            if (item is { }) // if not null
            {
                item.Quantity += quantity;
            }
            else
            {
                _items.Add(new BasketItem(CustomerId, itemId, quantity));
            }
        }

        //OVERLOADED METHOD
        public void RemoveItem(int itemId)
        {
            RemoveItem(itemId, 1);
        }

        public void RemoveItem(int itemId, int quantity)
        {
            var item = _items.FirstOrDefault(item => item.ItemId == itemId);
            if (item is { })
            {
                item.Quantity -= quantity;
                if (item.HasAny)
                {
                    _items.Remove(item);
                }
            }
        }

    }
}
