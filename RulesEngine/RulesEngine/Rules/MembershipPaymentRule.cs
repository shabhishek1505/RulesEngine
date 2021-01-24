using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.Constant;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    public class MembershipPaymentRule : IRule<IOrder>
    {
        public IOrder OrderType { get; set; }

        public List<Guid> ExecuteTask()
        {
            var result = new List<Guid>();
            //chain multiple activity if you want.
            if (OrderType.OrderTypeId == OrderConstants.MembershipPayment)
            {
                var activity = new ActivateMembership();
                var activity2 = new SendEmail();

                result.Add(activity2.ProcessActivity(OrderType));
                result.Add(activity.ProcessActivity(OrderType));
            }
            else if (OrderType.OrderTypeId == OrderConstants.MembershipUpgrade)
            {
                var activity = new UpgradeMembership();
                var activity2 = new SendEmail();

                result.Add(activity2.ProcessActivity(OrderType));
                result.Add(activity.ProcessActivity(OrderType));
            }
            return result;
        }
    }
}
