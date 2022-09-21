using DIProject_INT.Model;

namespace DIProject_INT.Interfaces;

public interface IStudentRepository
{
    void Add(Student s);

    void Update(Student s);

    void Delete(Student s);

    List<Student> GetAll();

    Student GetById(int id);
}