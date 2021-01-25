using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.OrderType;

namespace RulesEngine.Rules.Product
{
    public class BookPaymentRule:IRuleProduct
    {
        public List<Guid> ExecuteTask(IOrder order)
        {
            var result = new List<Guid>();
            var activity = new PackagingSlip();
            var activity2 = new CommissionAgent();
            result.Add(activity2.ProcessActivity(order));
            result.Add(activity.ProcessActivity(order));
            return result;
        }
    }
}
