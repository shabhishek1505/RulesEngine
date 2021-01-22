using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.OrderType;

namespace RulesEngine.ActivityType
{
    class ActivateMembership : IActivity
    {
        public Guid ActivityTypeId { get; } = Guid.Parse("f60d858d-9d93-43be-b86b-da7598b157e3");
        public string ActivityTypeName { get; } = "Activate_Membership";
        public bool ProcessActivity(IOrder order)
        {
            return true;
        }
    }
}
