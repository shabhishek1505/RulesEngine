using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.OrderType;

namespace RulesEngine.Rules.Product
{
    public class VideoPaymentRule:IRuleProduct
    {
        public List<Guid> ExecuteTask(IOrder order)
        {
            var result = new List<Guid>();
            var activity = new PackagingSlip();
            result.Add(activity.ProcessActivity(order));
            return result;
        }
    }
}
