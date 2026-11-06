class Student : Person
{
    private string group;
    private double averageGrade;

    public string Group
    {
        get { return group; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Группа не может быть пустой");
            }

            group = value;
        }
    }

    public double AverageGrade
    {
        get { return averageGrade; }
        set
        {
            if (value < 0 || value > 5)
            {
                throw new ArgumentException("Средний балл должен быть от 0 до 5");
            }

            averageGrade = value;
        }
    }

    public Student(string fullName, int age, string email,
                   string group, double averageGrade)
        : base(fullName, age, email)
    {
        Group = group;
        AverageGrade = averageGrade;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Роль: студент");
        Console.WriteLine("Группа: " + Group);
        Console.WriteLine("Средний балл: " + AverageGrade);
    }

    public void Study()
    {
        Console.WriteLine("Студент " + FullName + " учится в группе " + Group);
    }
}
