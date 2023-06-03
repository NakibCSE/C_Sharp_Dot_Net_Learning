using System.Security.Cryptography.X509Certificates;

public class Student
{
    private int _ID;
    private string _Name;
    private int _passMark = 40;
    private string _Email;

    public void setId(int id)
    {
        if(id <= 0)
        {
            throw new Exception("Student ID cannot be a negative number");
        }
        _ID = id;
    }
    public int getId()
    {
        return _ID;
    }

    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Student name cannot be null or empty");
        }
        _Name = name;
    }
    public string getName()
    {
       return string.IsNullOrEmpty(_Name) ? "No Name" : _Name;
    }

    public int getPassMark()
    {
        return _passMark;
    }

    public void setEmail(string email)
    {
        _Email = email;
    }
    public string getEmail()
    {
        return _Email;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.setId(221102);
        student.setName("Nakib");
        student.setEmail("Nakib@gmail.com");
        
        Console.WriteLine("The student ID = {0}", student.getId());
        Console.WriteLine("The student Name = {0}", student.getName());
        Console.WriteLine("The student emai = {0}", student.getEmail());
    }
}