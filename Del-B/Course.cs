class Course(string name, int maxSeats)
{
    public string Name = name;
    public int MaxSeats = maxSeats;

    public List<Student> Students = [];

    public void Enroll(Student studentToEnroll)
    {
        if(!Students.Contains(studentToEnroll))
        {
            if (Students.Count < MaxSeats)
            {
                Students.Add(studentToEnroll);
                studentToEnroll.Courses.Add(this);
            }
            else
            {
                  System.Console.WriteLine($"{this.Name} class is full");
            }
        }
        else
        {
           System.Console.WriteLine($"{studentToEnroll.Name} is already in {this.Name} class");  
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
            System.Console.WriteLine($"{this.Name} class does not have a student called {studentToRemove.Name}");
        }
    }
    public void RollCall()
    {
        if(Students.Count == 0)
        {
            System.Console.WriteLine($"{this.Name} class has no students");
        }
        else
        {
            System.Console.WriteLine($"{this.Name} class has: ");
            foreach (var student in Students)
            {
                System.Console.WriteLine(student.Name);
            }
            System.Console.WriteLine("As students");
        }
       
    }
    public override string ToString()
    {
        return $"{this.Name} ({Students.Count}/{this.MaxSeats} seats)";
    }

}