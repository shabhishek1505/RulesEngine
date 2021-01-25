using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Constant
{
    public static class ActivityConstants
    {
        public static Guid ActivateMembership { get; } = Guid.Parse("f60d858d-9d93-43be-b86b-da7598b157e3");
        public static Guid PackagingSlip { get; } = Guid.Parse("2ed794f8-23a7-493f-975d-792d98c3de60");
        public static Guid UpgradeMembership { get; } = Guid.Parse("c415ed87-6e0c-4dce-937f-1250c5388b7f");
        public static Guid SendEmail { get; } = Guid.Parse("cf4b3966-5ed1-44b6-bbbe-fc756664963d");
        public static Guid CommissionAgent { get; } = Guid.Parse("6dce3535-d352-4622-acd9-4cdbbaa340f4");
    }

    public static class OrderConstants
    {
        public static Guid MembershipPayment { get; } = Guid.Parse("2aa55553-653b-4302-82e7-990bc9e6ac04");
        public static Guid ProductPayment { get; } = Guid.Parse("53548363-d055-4ff3-974c-ac2646155d58");
        public static Guid BookPayment { get; } = Guid.Parse("e8d1fc99-cdf8-4f42-9ed6-0e6b324e89f1");
        public static Guid MembershipUpgrade { get; } = Guid.Parse("baefb4d2-ba7e-41cc-9c9a-0c934d58c440");
        public static Guid VideoPayment { get; } = Guid.Parse("a49c6df9-7ce6-4d37-b8c5-2d0471a0df70");
    }

    public static class VideoConstants
    {
        public static Guid LearningToSki { get; } = Guid.Parse("c653a3bc-da55-4c84-ab7c-3bc38d404633");
        public static Guid FirstAid { get; } = Guid.Parse("06d3d548-0774-4a36-b86d-b7a4e1d5c4f8");
    }
}
