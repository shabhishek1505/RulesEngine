using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RulesEngine.OrderType;
using RulesEngine.Rules;

namespace RulesEngine.RuleEngine
{
    public class RuleEngine
    {
        private readonly Dictionary<Guid, IRule<IOrder>> _rules;

        public RuleEngine(Dictionary<Guid, IRule<IOrder>> rules = null)
        {
            _rules = rules ?? new Dictionary<Guid, IRule<IOrder>>();
        }

        public void AddRule(IRule<IOrder> rule, Guid orderType)
        {
            _rules.Add(orderType, rule);
        }

        public Guid ProcessOrder(IOrder order)
        {
            //filters the fitting rule, and processes that rule for that order.

            var rule = _rules[order.OrderTypeId];
            return rule?.ExecuteTask() ?? Guid.Empty;
        }
    }
}
