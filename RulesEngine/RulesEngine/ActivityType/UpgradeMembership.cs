using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;
using RulesEngine.OrderType;

namespace RulesEngine.ActivityType
{
    public class UpgradeMembership:IActivity
    {
        public Guid ActivityTypeId { get; } = ActivityConstants.UpgradeMembership;
        public string ActivityTypeName { get; } = "UpgradeMembership";
        public Guid ProcessActivity(IOrder order)
        {
            return ActivityTypeId;
        }
    }
}
