using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repositoryPatternRecap.Interface;
using repositoryPatternRecap.Model;

namespace repositoryPatternRecap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Istudent _student;

        public StudentController(Istudent student)
        {
            _student = student;
        }


        [HttpGet]
        [Route("GetwithDate")]
        public async Task<ActionResult<List<Studentm>>> GetAll(DateTime startDate, DateTime endDate)
        {
            var student = await _student.GetAll(startDate, endDate);
                return Ok(student);
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<List<Studentm>>> GetAllStudent()
        {
            var student = await _student.GetAllStudent();

            return Ok(student);
        }

        [HttpGet]
        [Route("getWithID")]

        public async Task<ActionResult<List<Studentm>>> getStudentById(int id)
        {
            var stu = await _student.getStudentById(id);
            return Ok(stu);
        }





    }
}
