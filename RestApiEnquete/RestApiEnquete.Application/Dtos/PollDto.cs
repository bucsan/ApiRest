using System;
using System.Collections.Generic;

namespace RestApiEnquete.Application.Dtos
{
    public class PollDto
    {
        public int Id { get; set; }
        public string PollDescription { get; set; }
        public DateTime DateRegistration { get; set; }
        public int View { get; set; }
        public virtual List<OptionDto> Option { get; set; }
    }
}