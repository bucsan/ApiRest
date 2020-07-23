using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiEnquete.Application.Dtos
{
    public class VoteDto
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public DateTime DateRegistration { get; set; }
        public int Option_Id { get; set; }
    }
}
