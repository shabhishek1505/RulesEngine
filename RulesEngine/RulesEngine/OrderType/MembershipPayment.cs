using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;

namespace RulesEngine.OrderType
{
    public class MembershipPayment : IOrder
    {
        public Guid OrderId { get; set; }
        public Guid OrderTypeId { get; } = OrderConstants.MembershipPayment;
        public string OrderTypeName { get; } = "Membership_Payment";
    }
}
