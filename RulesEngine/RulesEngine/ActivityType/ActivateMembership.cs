using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;
using RulesEngine.OrderType;

namespace RulesEngine.ActivityType
{
    class ActivateMembership : IActivity
    {
        public Guid ActivityTypeId { get; } = ActivityConstants.ActivateMembership;
        public string ActivityTypeName { get; } = "Activate_Membership";
        public Guid ProcessActivity(IOrder order)
        {
            return ActivityTypeId;
        }
    }
}
