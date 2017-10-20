using System;
using System.Collections.Generic;
using System.Text;

namespace ColleageCourseAPI.Models
{
    public class CCModelsListing
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Beds { get; set; }
        public float Bath { get; set; }
        public int Sqft { get; set; }
    }
}
