using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;
using RulesEngine.OrderType;

namespace RulesEngine.ActivityType
{
    class CommissionAgent:IActivity
    {
        public Guid ActivityTypeId { get; } = ActivityConstants.CommissionAgent;
        public string ActivityTypeName { get; } = "Commission_Agent";
        public Guid ProcessActivity(IOrder order)
        {
            return ActivityTypeId;
        }
    }
}
