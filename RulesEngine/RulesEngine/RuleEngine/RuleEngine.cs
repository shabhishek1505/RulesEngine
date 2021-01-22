using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RulesEngine.OrderType;
using RulesEngine.Rules;

namespace RulesEngine.RuleEngine
{
    public class RuleEngine
    {
        private List<IRule> _rules;
        public RuleEngine(List<IRule> rules = null)
        {
            _rules = rules ?? new List<IRule>();
        }

        public void AddRule(IRule rule)
        {
            _rules.Add(rule);
        }

        public void ProcessOrder(IOrder order)
        {
            //filters the fitting rule, and processes that rule for that order.
        }
    }
}
