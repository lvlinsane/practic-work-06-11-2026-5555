class Person
{
    public string FullName { get; private set; }
    public int Age { get; private set; }
    public string Email { get; private set; }

    public Person(string fullName, int age, string email)
    {
        if (string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("ФИО не может быть пустым");
        }

        if (age < 0 || age > 120)
        {
            throw new ArgumentException("Возраст должен быть от 0 до 120 лет");
        }

        if (!IsEmailValid(email))
        {
            throw new ArgumentException("Некорректный адрес электронной почты");
        }

        FullName = fullName;
        Age = age;
        Email = email;
    }

    private static bool IsEmailValid(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        int at = email.IndexOf('@');
        int dot = email.LastIndexOf('.');

        if (at <= 0 || dot < at + 2 || dot >= email.Length - 1)
        {
            return false;
        }

        return !email.Contains(' ');
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("ФИО: " + FullName);
        Console.WriteLine("Возраст: " + Age);
        Console.WriteLine("Email: " + Email);
    }
}
