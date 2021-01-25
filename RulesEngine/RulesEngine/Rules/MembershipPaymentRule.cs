using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.Constant;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    public class MembershipPaymentRule : IRuleOrder<IOrder>
    {
        public IOrder OrderType { get; set; }

        public List<Guid> ExecuteTask(IOrder order)
        {
            var result = new List<Guid>();
            var sendEmail = new SendEmail();
            //chain multiple activity if you want. No need to add rule if not much of cyclomatic complexity
            if (order.OrderTypeId == OrderConstants.MembershipPayment)
            {
                var activity = new ActivateMembership();
                result.Add(activity.ProcessActivity(order));
            }
            else if (order.OrderTypeId == OrderConstants.MembershipUpgrade)
            {
                var activity = new UpgradeMembership();
                result.Add(activity.ProcessActivity(order));
            }
            result.Add(sendEmail.ProcessActivity(order));
            return result;
        }

    }
}
