using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Constant
{
    public static class ActivityConstants
    {
        public static Guid ActivateMembership { get; } = Guid.Parse("f60d858d-9d93-43be-b86b-da7598b157e3");
        public static Guid PackagingSlip { get; } = Guid.Parse("2ed794f8-23a7-493f-975d-792d98c3de60");
    }

    public static class OrderConstants
    {
        public static Guid MembershipPayment { get; } = Guid.Parse("2aa55553-653b-4302-82e7-990bc9e6ac04");
        public static Guid ProductPayment { get; }= Guid.Parse("53548363-d055-4ff3-974c-ac2646155d58");
    }
}
