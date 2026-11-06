Console.OutputEncoding = System.Text.Encoding.UTF8;

Person[] people = new Person[6];

people[0] = new Student("Петров Пётр Петрович", 19, "petrov@mail.com", "ИС-21", 4.3);
people[1] = new Student("Каримова Алия Ермековна", 20, "aliya@mail.com", "ИС-21", 4.8);
people[2] = new Student("Нурланов Нурлан Нурланович", 22, "nurlan@mail.com", "ПО-23", 3.1);
people[3] = new Teacher("Сидорова Анна Сергеевна", 45, "sidorova@mail.com", "Программирование", 20);
people[4] = new Teacher("Ахметов Ержан Маратович", 28, "ahmetov@mail.com", "Математика", 3);
people[5] = new Person("Иванов Иван Иванович", 35, "ivanov@mail.com");

foreach (Person person in people)
{
    person.DisplayInfo();

    if (person is Student student)
    {
        student.Study();

        if (student.AverageGrade >= 4.5)
        {
            Console.WriteLine("Дополнительно: отличник");
        }
        else if (student.AverageGrade >= 3.5)
        {
            Console.WriteLine("Дополнительно: хорошая успеваемость");
        }
        else
        {
            Console.WriteLine("Дополнительно: нужно подтянуть оценки");
        }
    }
    else if (person is Teacher teacher)
    {
        teacher.Teach();

        if (teacher.Experience < 5)
        {
            Console.WriteLine("Дополнительно: молодой специалист");
        }
        else if (teacher.Experience < 15)
        {
            Console.WriteLine("Дополнительно: опытный преподаватель");
        }
        else
        {
            Console.WriteLine("Дополнительно: преподаватель с большим стажем");
        }
    }
    else
    {
        Console.WriteLine("Это обычный человек, особых действий нет");
    }

    Console.WriteLine("----------------------------");
}

Console.WriteLine();
Console.WriteLine("=== Проверка некорректных данных ===");

try
{
    Student wrong = new Student("Тест Тестович", 200, "test@mail.com", "ИС-21", 4);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}
