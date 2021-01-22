using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RulesEngine.ActivityType
{
    public interface IActivity
    {
        public Guid ActivityTypeId { get; set; }
        public string ActivityTypeName { get; set; }
        public void ProcessActivity();
    }
}
