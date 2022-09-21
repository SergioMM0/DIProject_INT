namespace DIProject_INT.Model;

public class Student
{
    public int ID { get; set; }
    
    public string Name { get; set; }
    
    public string Email{ get; set; }

    public Student(int id, string name, string email)
    {
        ID = id;
        Name = name;
        Email = email;
    }
}