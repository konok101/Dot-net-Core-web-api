using repositoryPatternRecap.Model;

namespace repositoryPatternRecap.Interface
{
    public interface Istudent
    {
        Task<List<Studentm>> GetAll(DateTime startDate, DateTime endDate);
        Task<List<Studentm>> GetAllStudent();

        Task<List<Studentm>> getStudentById(int id);
    }
}
