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
        private RuleEngine<IRuleOrder<IOrder>> _ruleEngineOrder;

        [SetUp]
        public void Setup()
        {
            _ruleEngineOrder = new RuleEngine<IRuleOrder<IOrder>>();
            _ruleEngineOrder.AddRule(OrderConstants.MembershipPayment, new MembershipPaymentRule() { OrderType = new MembershipPayment() });
            _ruleEngineOrder.AddRule(OrderConstants.MembershipUpgrade, new MembershipPaymentRule() { OrderType = new MembershipUpgrade() });
            _ruleEngineOrder.AddRule(OrderConstants.BookPayment, new ProductPaymentRule() { OrderType = new BookPayment() });
            _ruleEngineOrder.AddRule(OrderConstants.VideoPayment, new ProductPaymentRule() { OrderType = new VideoPayment() });
        }

        [Test]
        public void Test_MembershipPayment()
        {
            var order = new MembershipPayment { Id = Guid.NewGuid() };
            var task = _ruleEngineOrder.ProcessOrder(order.OrderTypeId);
            var result = task.ExecuteTask(order);
            Assert.Contains(ActivityConstants.ActivateMembership, result);
            Assert.Contains(ActivityConstants.SendEmail, result);
        }
        [Test]
        public void Test_MembershipUpgrade()
        {
            var order = new MembershipUpgrade() { Id = Guid.NewGuid() };
            var task = _ruleEngineOrder.ProcessOrder(order.OrderTypeId);
            var result = task.ExecuteTask(order);
            Assert.Contains(ActivityConstants.UpgradeMembership, result);
            Assert.Contains(ActivityConstants.SendEmail, result);
        }
        [Test]
        public void Test_BookPayment()
        {
            var order = new BookPayment() { Id = Guid.NewGuid() };
            var task = _ruleEngineOrder.ProcessOrder(order.OrderTypeId);
            var result = task.ExecuteTask(order);
            Assert.Contains(ActivityConstants.PackagingSlip, result);
            Assert.Contains(ActivityConstants.CommissionAgent, result);
        }
        [Test]
        public void Test_VideoPayment()
        {
            var order = new VideoPayment()
            { Id = Guid.NewGuid(), ProductId = VideoConstants.LearningToSki };
            var task = _ruleEngineOrder.ProcessOrder(order.OrderTypeId);
            var result = task.ExecuteTask(order);
            Assert.Contains(VideoConstants.LearningToSki, result);
            Assert.Contains(VideoConstants.FirstAid, result);
        }
    }
}