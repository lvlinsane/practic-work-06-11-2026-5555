class Teacher : Person
{
    private string subject;
    private int experience;

    public string Subject
    {
        get { return subject; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Предмет не может быть пустым");
            }

            subject = value;
        }
    }

    public int Experience
    {
        get { return experience; }
        set
        {
            if (value < 0 || value > Age)
            {
                throw new ArgumentException("Стаж должен быть от 0 и не больше возраста");
            }

            experience = value;
        }
    }

    public Teacher(string fullName, int age, string email,
                   string subject, int experience)
        : base(fullName, age, email)
    {
        Subject = subject;
        Experience = experience;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Роль: преподаватель");
        Console.WriteLine("Предмет: " + Subject);
        Console.WriteLine("Стаж работы: " + Experience + " лет");
    }

    public void Teach()
    {
        Console.WriteLine("Преподаватель " + FullName + " проводит занятие по предмету " + Subject);
    }
}
