﻿using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    class ProductPaymentRule : IRule<ProductPayment>
    {
        public ProductPayment OrderType { get; set; }

        public void ExecuteTask()
        {
            //chain multiple activity if you want.
            var activity = new PackagingSlip();
            activity.ProcessActivity(OrderType);
        }
    }
}
