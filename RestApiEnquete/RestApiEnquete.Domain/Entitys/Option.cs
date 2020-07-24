using System;

namespace RestApiEnquete.Domain.Entitys
{
    public class Option : Base
    {
        public int Poll_Id { get; set; }
        public string OptionDescription { get; set; }
        public int Qty { get; set; }
        public DateTime DateRegistration { get; set; }
    }
}
