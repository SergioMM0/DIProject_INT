using DIProject_INT.Interfaces;
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
    }
}