using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    public interface IRule
    {
        public IOrder OrderType { get; set; }
        public void ExecuteTask();
    }
}
