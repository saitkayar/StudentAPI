using Microsoft.EntityFrameworkCore;
using StudentAPI.Model;

namespace StudentAPI.Repositories
{
    public class Repositories : IRepositories
    {
        private StudentDbContext _context;

        public Repositories(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAll()
        {
            return await _context.Student.Include(nameof(Gender)).Include(nameof(Adress)).ToListAsync();

        }

        public async Task<Student> GetStudentAsync(Guid id)
        {
            return await _context.Student.Include(nameof(Gender)).Include(nameof(Adress)).FirstOrDefaultAsync(p=>p.Id==id);
        }
    }
}
