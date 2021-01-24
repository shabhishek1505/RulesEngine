using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;
using RulesEngine.OrderType;

namespace RulesEngine.ActivityType
{
    class SendEmail : IActivity
    {
        public Guid ActivityTypeId { get; } = ActivityConstants.SendEmail;
        public string ActivityTypeName { get; } = "Send_Email";
        public Guid ProcessActivity(IOrder order)
        {
            return ActivityTypeId;
        }
    }
}
