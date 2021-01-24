using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;

namespace RulesEngine.OrderType
{
    public class MembershipUpgrade : IOrder
    {
        public Guid OrderId { get; set; }
        public Guid OrderTypeId { get; } = OrderConstants.MembershipUpgrade;
        public string OrderTypeName { get; } = "Membership_Upgrade";
    }
}
