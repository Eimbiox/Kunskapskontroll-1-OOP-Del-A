class Course(string name, int maxSeats)
{
    public string Name = name;
    public int MaxSeats = maxSeats;

    public List<Student> Students = [];

    public void Enroll(Student studentToEnroll)
    {
        if(Students.Count < MaxSeats)
        {
            if (!Students.Contains(studentToEnroll))
            {
                Students.Add(studentToEnroll);
                studentToEnroll.Courses.Add(this);
            }
            else
            {
                System.Console.WriteLine($"{studentToEnroll.Name} is already in {this.Name} class");   
            }
        }
        else
        {
            System.Console.WriteLine($"{this.Name} class is full");
        }
    }
    public void Remove(Student studentToRemove)
    {
        if (Students.Contains(studentToRemove))
        {
            Students.Remove(studentToRemove);
            studentToRemove.Courses.Remove(this);
        }
        else
        {
            System.Console.WriteLine($"{this.Name} class does not have a studend called {studentToRemove.Name}");
        }
    }
    public void RollCall()
    {
        System.Console.WriteLine($"{this.Name} class has: ");
        foreach (var student in Students)
        {
            System.Console.WriteLine(student.Name);
        }
        System.Console.WriteLine("As students");
    }

}