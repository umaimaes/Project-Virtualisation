using Microsoft.EntityFrameworkCore;
using ProjectVirtuqlisqtion.Data;
using ProjectVirtuqlisqtion.Models;

namespace ProjectVirtuqlisqtion.Services
{
   
    public class StudentService
    {
        private readonly DataContext _context;
        private Student? _currentStudent;
        public Student? GetStudent() => _currentStudent;
        public void SetStudent(Student student) => _currentStudent = student;
        public void EmptyStudent() => _currentStudent = null;

        public StudentService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Student>> GetAllAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task CreateStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> Login(string email, string password)
        {
            Student student = await _context.Students
                .FirstOrDefaultAsync(c => c.Email == email && c.Password == password);

            return student != null;
        }
    }
}
