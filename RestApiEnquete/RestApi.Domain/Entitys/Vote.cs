using System;

namespace RestApiEnquete.Domain.Entitys
{
    public class Vote : Base
    {
        public int Qty { get; set; }
        public DateTime DateRegistration { get; set; }
        public int Option_Id { get; set; }
    }
}