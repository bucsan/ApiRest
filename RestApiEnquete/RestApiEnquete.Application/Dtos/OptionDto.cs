using System.Dynamic;

namespace RestApiEnquete.Application.Dtos
{
    public class OptionDto
    {
        public int Id { get; set; }
        public string OptionDescription { get; set; }
        public int Poll_Id { get; set; }
    }
}