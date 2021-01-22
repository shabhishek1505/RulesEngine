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
        private List<IRule<IOrder>> _rules;

        public RuleEngine(List<IRule<IOrder>> rules = null)
        {
            _rules = rules ?? new List<IRule<IOrder>>();
        }

        public void AddRule(IRule<IOrder> rule)
        {
            _rules.Add(rule);
        }

        public bool ProcessOrder(IOrder order)
        {
            //filters the fitting rule, and processes that rule for that order.

            var rule = _rules.FirstOrDefault(x => x.OrderType.OrderTypeId == order.OrderTypeId);

            return rule?.ExecuteTask() ?? false;
        }
    }
}
