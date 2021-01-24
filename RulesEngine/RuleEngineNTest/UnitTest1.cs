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
            _ruleEngine.AddRule(OrderConstants.MembershipPayment, new MembershipPaymentRule() { OrderType = new MembershipPayment() });
            _ruleEngine.AddRule(OrderConstants.MembershipUpgrade, new MembershipPaymentRule() { OrderType = new MembershipUpgrade() });
            _ruleEngine.AddRule(OrderConstants.BookPayment, new ProductPaymentRule() { OrderType = new BookPayment() });
            _ruleEngine.AddRule(OrderConstants.VideoPayment, new ProductPaymentRule() { OrderType = new VideoPayment() });
        }

        [Test]
        public void Test_MembershipPayment()
        {
            var order = new MembershipPayment { OrderId = Guid.NewGuid() };
            var result = _ruleEngine.ProcessOrder(order);
            Assert.Contains(ActivityConstants.ActivateMembership, result);
            Assert.Contains(ActivityConstants.SendEmail, result);
        }
        [Test]
        public void Test_MembershipUpgrade()
        {
            var order = new MembershipUpgrade() { OrderId = Guid.NewGuid() };
            var result = _ruleEngine.ProcessOrder(order);
            Assert.Contains(ActivityConstants.UpgradeMembership, result);
            Assert.Contains(ActivityConstants.SendEmail, result);
        }
        [Test]
        public void Test_BookPayment()
        {
            var order = new BookPayment() { OrderId = Guid.NewGuid() };
            var result = _ruleEngine.ProcessOrder(order);
            Assert.Contains(ActivityConstants.PackagingSlip, result);
            Assert.Contains(ActivityConstants.CommissionAgent, result);
        }
        [Test]
        public void Test_VideoPayment()
        {
            var order = new VideoPayment() { OrderId = Guid.NewGuid() };
            var result = _ruleEngine.ProcessOrder(order);
            Assert.Contains(ActivityConstants.PackagingSlip, result);
        }
    }
}