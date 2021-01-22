using System;
using Microsoft.VisualBasic;
using NUnit.Framework;
using RulesEngine.OrderType;
using RulesEngine.RuleEngine;
using RulesEngine.Rules;
using RulesEngine.Constant;

namespace RuleEngineNTest
{
    public class Tests
    {
        private RuleEngine _ruleEngine;
        [SetUp]
        public void Setup()
        {
            _ruleEngine = new RuleEngine();
            _ruleEngine.AddRule(new MembershipPaymentRule() { OrderType = new MembershipPayment() }, OrderConstants.MembershipPayment);
            _ruleEngine.AddRule(new ProductPaymentRule() { OrderType = new ProductPayment() }, OrderConstants.ProductPayment);
        }

        [Test]
        public void Test_MembershipPayment()
        {
            var order = new MembershipPayment { OrderId = Guid.NewGuid() };
            Assert.AreEqual(_ruleEngine.ProcessOrder(order), ActivityConstants.ActivateMembership);
        }
        [Test]
        public void Test_ProductPayment()
        {
            var order = new ProductPayment { OrderId = Guid.NewGuid() };
            Assert.AreEqual(_ruleEngine.ProcessOrder(order), ActivityConstants.PackagingSlip);
        }
    }
}