using Microsoft.EntityFrameworkCore;
using repositoryPatternRecap.DBContext;
using repositoryPatternRecap.Interface;
using repositoryPatternRecap.Model;

namespace repositoryPatternRecap.Service
{
    public class StudentRepo:Istudent
    {
        public readonly ApplicationDBContext _dbContext;
        public StudentRepo(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List <Studentm>> GetAll(DateTime startDate, DateTime endDate)
        {
            return await _dbContext.Students
                .Where(Student => Student.Date >= startDate && Student.Date <= endDate)
                .ToListAsync();
        }

        public async Task<List<Studentm>> GetAllStudent()
        {
            return await _dbContext.Students.ToListAsync();
        }



        public async Task <List <Studentm>> getStudentById(int id)
        {
            var idStu = await _dbContext.Students.Where(s => s.Id == id).ToListAsync();
            return idStu;

        }
    }


}
