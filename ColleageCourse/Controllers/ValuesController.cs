using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ColleageCourseAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ColleageCourse.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public CCModelsProfileResult Get()
        {
            CCModelsListing[] listings = new CCModelsListing[]
            {
                new CCModelsListing { Id = 1, Address = "472 Ponderosa Dr, Alpine", Beds = 4, Bath = 3.0F, Sqft = 2785, Price = 345000, Favorite = false, Image = "/images/property/home1.jpg" },
                new CCModelsListing { Id = 2, Address = "472 Ponderosa Dr, Alpine", Beds = 4, Bath = 3.0F, Sqft = 2785, Price = 345000, Favorite = true, Image = "/images/property/home8.jpg" },
                new CCModelsListing { Id = 3, Address = "472 Ponderosa Dr, Alpine", Beds = 4, Bath = 3.0F, Sqft = 2785, Price = 345000, Favorite = false, Image = "/images/property/home11.jpg" },
            };

            CCModelsProfileResult result = new CCModelsProfileResult
            {
                Id = 1, 
                About = "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to exceed expectations and never forget that I am always accountable to my clients.<br /><br /> My objective is to establish relationships for life, not just for the current transaction.I enjoy assisting home buyers and sellers to get moved to a better place, one that is exciting.",
                Listings = listings,
                Brokerage = "Berkshire Hathaway HomeServices Elite Real Estate",
                Specialties = "Property Management, Buyer’s Agent, Listing Agent…",
                License = "#5452129",
                LocalKnowledgeScore = 4.5F,
                ProcessExpertiseScore = 4.2F,
                ResponsivenessScore = 5.0F,
                NegotiationSkillsScore = 4.1F
            };

            return result;
        }
        
    }
}
