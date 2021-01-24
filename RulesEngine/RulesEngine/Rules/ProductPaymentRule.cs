using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.Constant;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    public class ProductPaymentRule : IRule<IOrder>
    {
        public IOrder OrderType { get; set; }
        public List<Guid> ExecuteTask()
        {
            var result = new List<Guid>();
            //chain multiple activity if you want.
            if (OrderType.OrderTypeId == OrderConstants.BookPayment)
            {
                var activity = new PackagingSlip();
                var activity2 = new CommissionAgent();
                result.Add(activity2.ProcessActivity(OrderType));
                result.Add(activity.ProcessActivity(OrderType));
            }
            else if (OrderType.OrderTypeId == OrderConstants.VideoPayment)
            {
                var activity = new PackagingSlip();
                result.Add(activity.ProcessActivity(OrderType));
            }
            return result;

        }
    }
}
