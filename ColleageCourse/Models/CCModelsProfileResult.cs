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
    }
}
