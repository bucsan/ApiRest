using System;

namespace RestApiEnquete.Domain.Entitys
{
    public class Poll : Base
    {
        public string OptionDescription { get; set; }
        public DateTime DateRegistration { get; set; }
        public int View { get; set; }
        public virtual Option Option { get; set; }
    }
}
