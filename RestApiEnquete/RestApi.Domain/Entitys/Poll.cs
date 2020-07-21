
using System;

namespace RestApiEnquete.Domain.Entitys
{
    public class Poll : Base
    {
        public string PollDescription { get; set; }    
        public DateTime DateRegistration { get; set; }
        public Option[] Options { get; set; }
        
        /*
         * "poll_id": 1, 
            "poll_description": "This is the question". 
            "options": [ 
            {"option_id": 1, "option_description": "First option"}, 
            {"option_id": 2, "option_description": "Second option"}, 
            {"option_id": 3, "option_description": "Third option"}, 
            ]
         */
    }
}
