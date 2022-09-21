using DIProject_INT.Interfaces;
using DIProject_INT.Model;
using DIProject_INT.Service;
using Moq;

namespace XUnitTestProject
{
    public class StudentServiceTest
    {
        [Fact]
        public void CreateStudentService()
        {
            //Arrange
            Mock<IStudentRepository> mockRepository = new Mock<IStudentRepository>();
            IStudentRepository repository = mockRepository.Object;
            
            //Act
            StudentService service = new StudentService(repository);
            
            //Assert
            
            Assert.NotNull(service);
            
            
        }

        [Fact]
        public void CreateStudentServiceWithNULLRepositoryExpectArgumentNullException()
        {
            StudentService service = null;
            //Act
            Assert.Throws<ArgumentNullException>(() =>service = new StudentService(null));
            Assert.Null(service);
        }

        [Fact]
        public void AddValidStudent()
        {
            //Mock data
            List<Student> students = new List<Student>();
            //Arrange
            Mock<IStudentRepository> mockRepository = new Mock<IStudentRepository>();
            mockRepository.Setup(r => r.Add(It.IsAny<Student>())).Callback<Student>(s => students.Add(s));
            IStudentRepository repository = mockRepository.Object;
            
            StudentService service = new StudentService(repository);

            Student student = new Student(1, "Name", "Email");
            
            //Act

            service.AddStudent(student);
            
            //Assert
            
            Assert.NotEmpty(students);
            Assert.Contains(student, students);
            mockRepository.Verify(r => r.Add(student), Times.Once);
        }

        [Fact]
        public void AddStudentwithNULLExpectArgumentNullException()
        {
            //Mock data
            List<Student> students = new List<Student>();
            //Arrange
            Mock<IStudentRepository> mockRepository = new Mock<IStudentRepository>();
            mockRepository.Setup(r => r.Add(It.IsAny<Student>())).Callback<Student>(s => students.Add(s));
            IStudentRepository repository = mockRepository.Object;
            
            StudentService service = new StudentService(repository);
            
            //Act

            Action ac = () => service.AddStudent(null);

            Assert.Throws<ArgumentNullException>(ac);
            Assert.Empty(students);
            mockRepository.Verify(r => r.Add(null),Times.Never);
        }
    }
}