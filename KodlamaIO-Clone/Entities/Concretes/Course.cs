using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : Entity
    {
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public int CourseProgrammeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Instructor Instructor { get; set; }
        public Category Category { get; set; }
        public CourseProgramme CourseProgramme { get; set; }

        public Course()
        {

        }

        public Course(int id, int instructorId, int categoryId, int courseProgrammeId, string name, string description, string imageUrl) : this()
        {
            Id = id;
            InstructorId = instructorId;
            CategoryId = categoryId;
            CourseProgrammeId = courseProgrammeId;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}