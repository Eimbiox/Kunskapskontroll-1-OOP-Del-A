class Student(string name)
{
    public string Name = name;

    public List<Course> Courses = [];

    public void Join(Course courseToJoin)
    {
        if (!Courses.Contains(courseToJoin))
        {
            if (courseToJoin.Students.Count < courseToJoin.MaxSeats)
            {
                Courses.Add(courseToJoin);
                courseToJoin.Students.Add(this);
            }
            else
            {
                System.Console.WriteLine($"{courseToJoin.Name} class is full");
            }
        }
        else
        {
            System.Console.WriteLine($"{this.Name} is already in {courseToJoin.Name} class");
        }
    }
    public void Leave(Course courseToLeave)
    {
        if (courseToLeave.Students.Contains(this))
        {
            courseToLeave.Students.Remove(this);
            Courses.Remove(courseToLeave);
        }
        else
        {
            System.Console.WriteLine($"{this.Name} is not in {courseToLeave.Name} class");
        }
    }
    public void Schedule()
    {
        if (Courses.Count == 0)
        {
            System.Console.WriteLine($"{this.Name} is not in any classes");
        }
        else
        {
             System.Console.WriteLine($"{this.Name} is in theese classes: ");

            foreach (var course in Courses)
            {
            System.Console.WriteLine($"{course.Name} class");
            }
        }
       
    }
    public override string ToString()
    {
        return this.Name;
    }

}