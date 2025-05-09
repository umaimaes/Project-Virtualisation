using Microsoft.EntityFrameworkCore;
using ProjectVirtuqlisqtion.Data;
using ProjectVirtuqlisqtion.Models;

namespace ProjectVirtuqlisqtion.Services
{
    public class CourseService
    {
        private readonly DataContext _context;
        private Course? _currentCourse;
        public Course? GetCourse() => _currentCourse;
        public void SetCourse(Course course) => _currentCourse = course;
        public void EmptyCourse() => _currentCourse = null;

        public CourseService( DataContext context)
        {
            _context = context;
        }
        public async Task<List<Course>> GetAllAsync()
        {
            return await _context.Courses
                .Include(c => c.Curriculum)
                .Include(c => c.Instructor)
                .Include(c => c.WhatYouWillLearns)
                .ToListAsync();
        }
    }
}
