﻿using System.ComponentModel.DataAnnotations.Schema;

namespace lms.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public string Author { get; set; }

        public string imageURL { get; set; }   
        public virtual Category? Category { get; set; }

        public Course() { }

    }
}