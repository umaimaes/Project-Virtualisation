namespace ProjectVirtuqlisqtion.Models
{
    public class Course
    {
       
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; } // e.g., "Development"

        // Course meta information
        public string Level { get; set; } // e.g., "Beginner"
        public int Hours { get; set; } // Duration in hours

        // Pricing information
        public decimal Price { get; set; }

        // Instructor information
        public Instructor Instructor { get; set; }

        // Course content
        public string ImageUrl { get; set; }
        public List<WhatYouWillLearn> WhatYouWillLearns { get; set; }
        public string AboutContent { get; set; }
        public List<CourseSection> Curriculum { get; set; }
    }
   
}
