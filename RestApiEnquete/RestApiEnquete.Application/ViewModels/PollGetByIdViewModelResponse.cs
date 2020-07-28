using System.Collections.Generic;

namespace RestApiEnquete.Application.ViewModels
{
    public class PollGetByIdViewModelResponse
    {
        public int Poll_Id { get; set; }
        public string Poll_Description { get; set; }
        public List<PollGetByIdViewModelResponseOption> Options { get; set; }
    }

    public class PollGetByIdViewModelResponseOption
    {
        public int Option_Id { get; set; }
        public string Option_Description { get; set; }
    }
}