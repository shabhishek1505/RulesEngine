using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using RulesEngine.OrderType;

namespace RulesEngine.ActivityType
{
    public interface IActivity
    {
        public Guid ActivityTypeId { get;}
        public string ActivityTypeName { get;}
        public bool ProcessActivity(IOrder order);
    }
}
