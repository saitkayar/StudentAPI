using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.DomainModels;
using StudentAPI.Repositories;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IRepositories _repositories;
        private IMapper _mapper;
        public StudentsController(IRepositories repositories,IMapper mapper)
        {
            _mapper = mapper;
            _repositories = repositories;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result =await _repositories.GetAll();
      

           
            return Ok(_mapper.Map<List<Student>>(result));
        }
        [HttpGet("getstudent")]
        public async Task<IActionResult> GetStudentAsync(Guid id)
        {
            var result = await _repositories.GetStudentAsync(id);
            if (result==null)
            {
                return NotFound();
            }


            return Ok(_mapper.Map<Student>(result));
        }
    }
}
