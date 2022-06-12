using StudentAPI.Model;

namespace StudentAPI.Repositories
{
    public interface IRepositories
    {
       Task< List<Student>> GetAll();
        Task<Student> GetStudentAsync(Guid id);

    }
}
