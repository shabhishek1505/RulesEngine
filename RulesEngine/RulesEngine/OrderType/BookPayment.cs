﻿using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Constant;

namespace RulesEngine.OrderType
{
    public class BookPayment:IOrder
    {
        public Guid Id { get; set; }
        public Guid OrderTypeId { get; } = OrderConstants.BookPayment;
        public string OrderTypeName { get; } = "Book_Payment";
        public Guid ProductId { get; set; }
    }
}
