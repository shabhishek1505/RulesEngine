using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.OrderType
{
    public interface IOrder
    {
        public Guid OrderTypeId { get; set; }
        public string OrderTypeName { get; set; }
    }
}
