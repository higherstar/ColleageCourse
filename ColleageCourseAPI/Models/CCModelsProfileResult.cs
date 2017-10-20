using System;
using System.Collections.Generic;
using System.Text;

namespace ColleageCourseAPI.Models
{
    public class CCModelsProfileResult
    {
        public int Id { get; set; }
        public string About { get; set; }
        public string Brokerage { get; set; }
        public string Specialties { get; set; }
        public string License { get; set; }
        public float LocalKnowledgeScore { get; set; }
        public float ProcessExpertiseScore { get; set; }
        public float ResponsivenessScore { get; set; }
        public float NegotiationSkillsScore { get; set; }
        public IEnumerable<CCModelsListing> Listings { get; set; }
    }
}
