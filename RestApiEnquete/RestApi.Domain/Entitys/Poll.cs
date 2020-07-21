using System;

namespace RestApiEnquete.Domain.Entitys
{
    public class Poll : Base
    {
        public string PollDescription { get; set; }
        public DateTime DateRegistration { get; set; }
        public Option[] Options { get; set; }
    }
}