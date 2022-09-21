using DIProject_INT.Interfaces;

namespace DIProject_INT.Service;

public class StudentService
{
    private IStudentRepository repository;
    public StudentService(IStudentRepository repository)
    {
        if (repository == null)
            throw new ArgumentNullException();
        this.repository = repository;
    }
}