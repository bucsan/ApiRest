using System;

namespace RestApiEnquete.Application.Dtos
{
    public class PollDto
    {
        public int Id { get; set; }
        public string OptionDescription { get; set; }
        public DateTime DateRegistration { get; set; }
        public int View { get; set; }
        public virtual OptionDto Option { get; set; }
    }
}