using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    class MembershipPaymentRule : IRule<MembershipPayment>
    {
        public MembershipPayment OrderType { get; set; }
        public void ExecuteTask()
        {
            //chain multiple activity if you want.
            var activity = new ActivateMembership();
            activity.ProcessActivity(OrderType);
        }
    }
}
