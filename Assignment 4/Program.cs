using System.Drawing;

namespace Assignment_4
{
    


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ask 1.1
            //static void PassByValue(int number)
            //{
            //    number = 100;
            //}

            //int x = 10;

            //PassByValue(x);

            //Console.WriteLine(x);
            #endregion
            #region Ask 1.2
            //static void PassByReference(ref int number)
            //{
            //    number = 100;
            //}

            //int x = 10;

            //PassByReference(ref x);

            //Console.WriteLine(x);
            #endregion
            #region Ask 1.3
            //static void Calculate(int a, int b, int c, int d, out int sum, out int subtraction)
            //{
            //    sum = a + b + c + d;
            //    subtraction = a - b - c - d;
            //}

            //Console.Write("Enter first number: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter fourth number: ");
            //int d = Convert.ToInt32(Console.ReadLine());

            //Calculate(a, b, c, d, out int sum, out int subtraction);

            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("Subtraction = " + subtraction);

            #endregion
            #region Ask 1.4
            //static void Calculate(int a, int b, int c, int d, out int sum, out int subtraction)
            //{
            //    sum = a + b + c + d;
            //    subtraction = a - b - c - d;
            //}

            //Console.Write("Enter first number: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter fourth number: ");
            //int d = Convert.ToInt32(Console.ReadLine());

            //Calculate(a, b, c, d, out int sum, out int subtraction);

            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("Subtraction = " + subtraction);
            #endregion
            #region Ask 1.5
            //static bool IsPrime(int number)
            //{
            //    if (number < 2)
            //        return false;

            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }

            //    return true;
            //}

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(IsPrime(number));
            #endregion
            #region Ask 1.6
            //static void MinMaxArray(int[] numbers, ref int min, ref int max)
            //{
            //    min = numbers[0];
            //    max = numbers[0];

            //    for (int i = 1; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] < min)
            //            min = numbers[i];

            //        if (numbers[i] > max)
            //            max = numbers[i];
            //    }
            //}

            //int[] numbers = { 10, 5, 20, 3, 15 };

            //int min = 0;
            //int max = 0;

            //MinMaxArray(numbers, ref min, ref max);

            //Console.WriteLine("Minimum = " + min);
            //Console.WriteLine("Maximum = " + max);
            #endregion
            #region Ask 1.7
            //static long Factorial(int number)
            //{
            //    long result = 1;

            //    for (int i = 1; i <= number; i++)
            //    {
            //        result *= i;
            //    }

            //    return result;
            //}

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Factorial = " + Factorial(number));
            #endregion
            #region Ask 1.8
            //static string ChangeChar(string text, int position, char newChar)
            //{
            //    char[] chars = text.ToCharArray();

            //    chars[position] = newChar;

            //    return new string(chars);
            //}

            //Console.Write("Enter a string: ");
            //string text = Console.ReadLine();

            //Console.Write("Enter position: ");
            //int position = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter new character: ");
            //char newChar = Convert.ToChar(Console.ReadLine());

            //string result = ChangeChar(text, position, newChar);

            //Console.WriteLine("Result = " + result);
            #endregion
            #region Ask 2.1

            //foreach (Class1.WeekDays day in Enum.GetValues(typeof(Class1.WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion
            #region Ask 2.2

            //Person[] people = new Person[3];

            //people[0] = new Person
            //{
            //    Name = "Ahmed",
            //    Age = 22
            //};

            //people[1] = new Person
            //{
            //    Name = "Ali",
            //    Age = 25
            //};

            //people[2] = new Person
            //{
            //    Name = "Omar",
            //    Age = 20
            //};

            //foreach (Person person in people)
            //{
            //    Console.WriteLine("Name: " + person.Name);
            //    Console.WriteLine("Age: " + person.Age);
            //    Console.WriteLine();
            //}
            #endregion
            #region Ask 2.3
            //Console.Write("Enter season: ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;

            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;

            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;

            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season.");
            //}
            #endregion
            #region Ask 2.4

            Permissions userPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine("Current Permissions: " + userPermissions);

            userPermissions |= Permissions.Delete;

            Console.WriteLine("After Adding Delete: " + userPermissions);

            userPermissions &= ~Permissions.Write;

            Console.WriteLine("After Removing Write: " + userPermissions);

            if ((userPermissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read permission exists.");
            }
            else
            {
                Console.WriteLine("Read permission does not exist.");
            }
            #endregion
            #region Ask 2.5

            //Console.Write("Enter a color: ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    Console.WriteLine(color + " is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine("The input color is not a primary color.");
            //}
            #endregion
            #region Ask 2.6

            //Console.Write("Enter X1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter X2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Point point1 = new Point
            //{
            //    X = x1,
            //    Y = y1
            //};

            //Point point2 = new Point
            //{
            //    X = x2,
            //    Y = y2
            //};

            //double distance = Math.Sqrt(
            //    Math.Pow(point2.X - point1.X, 2) +
            //    Math.Pow(point2.Y - point1.Y, 2)
            //);

            //Console.WriteLine("Distance = " + distance);
            #endregion
            #region Ask 2.7
            //Person2[] people = new Person2[3];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.Write("Enter name of person " + (i + 1) + ": ");
            //    string name = Console.ReadLine();

            //    Console.Write("Enter age of person " + (i + 1) + ": ");
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    people[i] = new Person2
            //    {
            //        Name = name,
            //        Age = age
            //    };
            //}

            //Person2 oldest = people[0];

            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //    {
            //        oldest = people[i];
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Oldest Person:");
            //Console.WriteLine("Name: " + oldest.Name);
            //Console.WriteLine("Age: " + oldest.Age);
            #endregion
         


        }
    }

    
}
