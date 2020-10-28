using Domain.Models;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectForAITUCanteen.Domain.Requests
{
    public class CreateOrderRequest : IRequest<Order>
    {
        public CreateOrderRequest(List<Item> items)
        {
            ItemsToBuy = items;
        }
        public List<Item> ItemsToBuy { get; }
    }

    public class CreateOrderRequestHandler : IRequestHandler<CreateOrderRequest, Order>
    {
        private readonly ILogger<CreateOrderRequestHandler> _logger;

        public CreateOrderRequestHandler(ILogger<CreateOrderRequestHandler> logger)
        {
            _logger = logger;
        }

        public Task<Order> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            var order = new Order();
            request.ItemsToBuy.ForEach(item => order.AddItem(item));
            return Task.FromResult(order);
        }
    }
}
