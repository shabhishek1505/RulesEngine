using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;

namespace RulesEngine.OrderType
{
    public class MembershipPayment : IOrder
    {
        private IOrder _orderImplementation;
        public Guid Id { get; set; }
        public Guid OrderTypeId { get; } = OrderConstants.MembershipPayment;
        public string OrderTypeName { get; } = "Membership_Payment";
        public Guid ProductId { get; set; }
    }
}
