// See https://aka.ms/new-console-template for more information

static int CalculateAge(int day, int month, int year)
{
    DateTime birthDate = new DateTime(year, month, day);
    DateTime currentDate = DateTime.Now;

    int age = currentDate.Year - birthDate.Year;

    // Check if the birth date hasn't occurred yet in the current year
    if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
    {
        age--;
    }

    return age;
}

Console.WriteLine("Please enter your birthdate (DD MM YYYY):");
Console.Write("Day: ");
int day = int.Parse(Console.ReadLine());

Console.Write("Month: ");
int month = int.Parse(Console.ReadLine());

Console.Write("Year: ");
int year = int.Parse(Console.ReadLine());

int age = CalculateAge(day, month, year);
Console.WriteLine("Your current age is: " + age);
