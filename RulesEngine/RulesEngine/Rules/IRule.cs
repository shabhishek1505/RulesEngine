using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    public interface IRule<TO> where TO : IOrder
    {
        public TO OrderType { get; set; }
        public bool ExecuteTask();
    }
}
