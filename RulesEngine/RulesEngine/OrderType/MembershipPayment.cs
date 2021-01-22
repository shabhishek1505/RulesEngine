using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.OrderType
{
    public class MembershipPayment : IOrder
    {
        public Guid OrderId { get; set; }
        public Guid OrderTypeId { get; } = Guid.Parse("2aa55553-653b-4302-82e7-990bc9e6ac04");
        public string OrderTypeName { get; } = "Membership_Payment";
    }
}
