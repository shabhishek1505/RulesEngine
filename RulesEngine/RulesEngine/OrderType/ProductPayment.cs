using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;

namespace RulesEngine.OrderType
{
    public class ProductPayment : IOrder
    {
        public Guid OrderId { get; set; }
        public Guid OrderTypeId { get; } = OrderConstants.ProductPayment;
        public string OrderTypeName { get; } = "Physical_Product_Payment";
    }
}
