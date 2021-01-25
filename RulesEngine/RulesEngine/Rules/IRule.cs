﻿using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.OrderType;

namespace RulesEngine.Rules
{
    public interface IRule
    {
        public List<Guid> ExecuteTask(IOrder order);
    }
}
