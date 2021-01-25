using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.Constant;
using RulesEngine.OrderType;
using RulesEngine.RuleEngine;
using RulesEngine.Rules.Product;

namespace RulesEngine.Rules
{
    public class ProductPaymentRule : IRuleOrder<IOrder>
    {
        private readonly RuleEngine<IRuleProduct> _ruleEngine;

        public ProductPaymentRule()
        {
            _ruleEngine = new RuleEngine<IRuleProduct>();
            _ruleEngine.AddRule(OrderConstants.BookPayment, new BookPaymentRule());
            _ruleEngine.AddRule(OrderConstants.VideoPayment, new VideoPaymentRule());
        }
        public IOrder OrderType { get; set; }
        public List<Guid> ExecuteTask(IOrder order)
        {
            var result = new List<Guid>();
            result.AddRange(_ruleEngine.ProcessOrder(order));
            return result;

        }

    }
}
