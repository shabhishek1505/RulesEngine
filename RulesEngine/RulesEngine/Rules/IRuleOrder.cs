using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    public interface IRuleOrder<TO> : IRule where TO : IOrder
    {
        public IOrder OrderType { get; set; }
    }
}
