using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.OrderType;

namespace RulesEngine.ActivityType
{
    public class PackagingSlip:IActivity
    {
        public Guid ActivityTypeId { get; } = Guid.Parse("2ed794f8-23a7-493f-975d-792d98c3de60");
        public string ActivityTypeName { get; } = "Generate_Packaging_Slip";
        public bool ProcessActivity(IOrder order)
        {
            return true;
        }
    }
}
