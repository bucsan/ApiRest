using System;

namespace RestApiEnquete.Domain.Entitys
{
    public class Option : Base
    {
        public string OptionDescription { get; set; }
        public DateTime DateRegistration { get; set; }
    }
}