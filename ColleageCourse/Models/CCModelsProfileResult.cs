using System;
using System.Collections.Generic;
using System.Text;

namespace ColleageCourseAPI.Models
{
    public class CCModelsProfileResult
    {
        public int Id { get; set; }
        public string About { get; set; }
        public IEnumerable<CCModelsListing> Listings { get; set; }
        public string Brokerage { get; internal set; }
        public string Specialties { get; internal set; }
        public string License { get; internal set; }
        public float LocalKnowledgeScore { get; internal set; }
        public float ProcessExpertiseScore { get; internal set; }
        public float ResponsivenessScore { get; internal set; }
        public float NegotiationSkillsScore { get; internal set; }
    }
}
