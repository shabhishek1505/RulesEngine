using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.OrderType
{
    public class ProductPayment : IOrder
    {
        public Guid OrderId { get; set; }
        public Guid OrderTypeId { get; } = Guid.Parse("53548363-d055-4ff3-974c-ac2646155d58");
        public string OrderTypeName { get; } = "Physical_Product_Payment";
    }
}
