using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.Constant;

namespace RulesEngine.OrderType
{
    public class VideoPayment : IOrder
    {
        public Guid OrderId { get; set; }
        public Guid OrderTypeId { get; } = OrderConstants.VideoPayment;
        public Guid VideoGuid { get; set; }
        public string OrderTypeName { get; } = "Video_Payment";
    }
}
