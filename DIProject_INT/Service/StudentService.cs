using DIProject_INT.Interfaces;
using DIProject_INT.Model;

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

    public void AddStudent(Student student)
    {
        if (student == null)
            throw new ArgumentNullException();
        repository.Add(student);
        
    }
}