using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;
using RulesEngine.OrderType;

namespace RulesEngine.ActivityType
{
    public class PackagingSlip:IActivity
    {
        public Guid ActivityTypeId { get; } = Constants.PackagingSlip;
        public string ActivityTypeName { get; } = "Generate_Packaging_Slip";
        public Guid ProcessActivity(IOrder order)
        {
            return ActivityTypeId;
        }
    }
}
