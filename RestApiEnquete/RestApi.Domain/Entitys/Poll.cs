using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace RestApiEnquete.Domain.Entitys
{
    public class Poll : Base
    {
        public string PollDescription { get; set; }
        public DateTime DateRegistration { get; set; }
        public int? View { get; set; }
        public virtual IEnumerable<Option> Option { get; set; }
    }
}