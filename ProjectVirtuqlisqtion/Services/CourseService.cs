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
                .Include(c=>c.Quiz)
                    .ThenInclude(c=>c.Options)
                .Include(c => c.Instructor)
                .Include(c => c.WhatYouWillLearns)
                .ToListAsync();
        }

        public async Task CreateCourseSection(CourseSection cs)
        {
            _context.CourseSections.Add(cs);
            await _context.SaveChangesAsync();
        }
        public async Task CreateQuizoption(QuizOption qo)
        {
            _context.QuizOptions.Add(qo);
            await _context.SaveChangesAsync();
        }
        public async Task CreateQuizQuestion(QuizQuestion qq)
        {
            _context.QuizQuestions.Add(qq);
            await _context.SaveChangesAsync();
        }
        public async Task CreateInstructoe(Instructor i)
        {
            _context.Instructors.Add(i);
            await _context.SaveChangesAsync();
        }
        public async Task CreateWhats(WhatYouWillLearn ww)
        {
            _context.Whats.Add(ww);
            await _context.SaveChangesAsync();
        }
        public async Task CreateCourse(Course c)
        {
            _context.Courses.Add(c);
            await _context.SaveChangesAsync();
        }
    }
}
