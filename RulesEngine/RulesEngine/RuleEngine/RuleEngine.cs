using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RulesEngine.OrderType;
using RulesEngine.Rules;

namespace RulesEngine.RuleEngine
{
    public class RuleEngine<T>
    {
        private readonly Dictionary<Guid, T> _rules;

        public RuleEngine(Dictionary<Guid, T> rules = null)
        {
            _rules = rules ?? new Dictionary<Guid, T>();
        }

        public void AddRule(Guid orderType, T rule)
        {
            _rules.Add(orderType, rule);
        }

        public T ProcessOrder(Guid order)
        {
            //filters the fitting rule, and processes that rule for that order.

            var rule = _rules[order];
            return rule;
        }
    }
}
