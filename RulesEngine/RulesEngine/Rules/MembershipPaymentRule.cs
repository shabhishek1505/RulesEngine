using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    public class MembershipPaymentRule : IRule<IOrder>
    {
        public IOrder OrderType { get; set; }

        public Guid ExecuteTask()
        {
            //chain multiple activity if you want.
            var activity = new ActivateMembership();
            return activity.ProcessActivity(OrderType);
        }
    }
}
