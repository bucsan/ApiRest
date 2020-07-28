using System;
using System.Collections.Generic;

namespace RestApiEnquete.Domain.Entitys
{
    public class Poll : Base
    {
        public string OptionDescription { get; set; }
        public DateTime DateRegistration { get; set; }
        public int View { get; set; }
        public virtual List<Option> Option { get; set; }
    }
}
