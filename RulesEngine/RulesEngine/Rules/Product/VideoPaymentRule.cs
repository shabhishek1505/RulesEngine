using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.ActivityType;
using RulesEngine.Constant;
using RulesEngine.OrderType;
using RulesEngine.RuleEngine;

namespace RulesEngine.Rules.Product
{
    public class VideoPaymentRule : IRuleProduct
    {
        private readonly RuleEngine<List<Guid>> _ruleEngine;

        public VideoPaymentRule()
        {
            //rules should be injected and formed during startup
            _ruleEngine = new RuleEngine<List<Guid>>();
            _ruleEngine.AddRule(VideoConstants.LearningToSki, new List<Guid>() { VideoConstants.LearningToSki, VideoConstants.FirstAid });
        }
        public List<Guid> ExecuteTask(IOrder order)
        {
            var videos = _ruleEngine.ProcessOrder(order.ProductId);
            return videos;
        }
    }
}
