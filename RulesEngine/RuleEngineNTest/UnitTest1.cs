using System;
using NUnit.Framework;
using RulesEngine.OrderType;
using RulesEngine.RuleEngine;
using RulesEngine.Rules;

namespace RuleEngineNTest
{
    public class Tests
    {
        private RuleEngine _ruleEngine;
        [SetUp]
        public void Setup()
        {
            _ruleEngine = new RuleEngine();
            _ruleEngine.AddRule(new MembershipPaymentRule(){OrderType = new MembershipPayment()});
            _ruleEngine.AddRule(new ProductPaymentRule() { OrderType = new ProductPayment() });
        }

        [Test]
        public void Test1()
        {
            var order = new MembershipPayment();
            order.OrderId = Guid.NewGuid();
            Assert.IsTrue(_ruleEngine.ProcessOrder(order));
        }
    }
}