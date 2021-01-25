using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.OrderType
{
    public interface IOrder
    {
        public Guid Id { get; set; }
        public Guid OrderTypeId { get; }
        public string OrderTypeName { get; }
        public Guid ProductId { get; set; }
    }
}
