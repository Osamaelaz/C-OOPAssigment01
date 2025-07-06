namespace C_OOPAssigment01
{
    internal enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    internal enum Season
    {
        Spring, Summer, Autumn, Winter
    }


    [Flags]
    internal enum Permissions : byte
    {

        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    internal enum Colors
    {
        Red, Green, Blue
    }
    internal struct Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //Console.WriteLine("all the days of the week:");
            //foreach(WeekDays day in Enum.GetValues<WeekDays>())
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] Person = new Person[3];
            //Person[0] = new Person() { Name="osama",Age=21};
            //Person[1] = new Person() { Name = "Elsaid", Age = 24 };
            //Person[2] = new Person() { Name = "Mohamed", Age = 27 };
            //for (int i = 0; i < 3; i++)Console.WriteLine($"Person[{i}] Name: {Person[i].Name} ,  Age: {Person[i].Age}");
            #endregion
            #region 3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Please Enter Your Season:");
            //Season season;
            //bool isparsed;
            //do
            //{
            //    isparsed = Enum.TryParse<Season>(Console.ReadLine(), out season);
            //    if (!isparsed) Console.WriteLine("Invaild Season , Try Again");
            //} while (!isparsed);
            //string rangeMonths = season switch
            //{
            //    Season.Spring => "spring march to may",
            //    Season.Summer => "summer june to august",
            //    Season.Winter => " winter December to February",
            //    Season.Autumn => "autumn September to November",
            //    _ => "UnKnown"
            //};
            //Console.WriteLine(rangeMonths);
            #endregion
            #region  4. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //Permissions Permission = Permissions.Read | Permissions.Write;

            //Console.WriteLine($"Current Permissions: {Permission}");

            //// Add Permission
            //Permission |= Permissions.Delete;
            //Console.WriteLine($"After Adding Delete: {Permission}");

            //// Remove Permission
            //Permission &= ~Permissions.Read;
            //Console.WriteLine($"After Removing Read: {Permission}");

            //// Check Permission
            //bool hasWrite = (Permission & Permissions.Write) == Permissions.Write;
            //Console.WriteLine($"Has Write Permission: {hasWrite}");
            #endregion
            #region 5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not

            //Console.WriteLine("Please Enter Your Color Name:");
            //string input = Console.ReadLine();
            //if (Enum.TryParse<Colors>(input, out Colors color))
            //{
            //    Console.WriteLine($"Your Color {color} is Primary Color");
            //}
            //else
            //{
            //    Console.WriteLine($"Your Color {input} is Not Primary Color");
            //}
            #endregion
            #region 6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Point P1 = new Point();
            //Point P2=new Point();
            //Console.WriteLine("Enter (X,Y) Of P1");
            //bool isparsed;
            //double x1, x2, y1, y2;
            //do
            //{
            //    Console.WriteLine("X1:");
            //    isparsed = double.TryParse(Console.ReadLine(), out x1);
            //    if (!isparsed) Console.WriteLine("Invaild Input , Try Again.");

            //} while (!isparsed);
            //P1.X = x1;
            //do
            //{
            //    Console.WriteLine("Y1:");
            //    isparsed = double.TryParse(Console.ReadLine(), out y1);
            //    if (!isparsed) Console.WriteLine("Invaild Input , Try Again.");

            //} while (!isparsed);
            //P1.Y = y1;

            //Console.WriteLine("Enter (X,Y) Of P2");
            //do
            //{
            //    Console.WriteLine("X2:");
            //    isparsed = double.TryParse(Console.ReadLine(), out x2);
            //    if (!isparsed) Console.WriteLine("Invaild Input , Try Again.");
            //} while (!isparsed);
            //P2.X = x2;
            //do
            //{
            //    Console.WriteLine("Y2:");
            //    isparsed = double.TryParse(Console.ReadLine(), out y2);
            //    if (!isparsed) Console.WriteLine("Invaild Input , Try Again.");

            //} while (!isparsed);
            //P2.Y = y2;

            //double distance = Math.Sqrt(Math.Pow((P2.Y - P1.Y), 2) + Math.Pow((P2.X - P1.X), 2));
            //Console.WriteLine($"distance : {distance:F2}");
            #endregion
            #region 7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] person = new Person[3];
            //Person oldest = person[0];
            //bool isparsed;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Person[{i}]:");
            //    Console.WriteLine("Name:");
            //    person[i].Name = Console.ReadLine();
            //    int age;
            //    do
            //    {
            //        Console.WriteLine("Age:");
            //        isparsed = int.TryParse(Console.ReadLine(), out age);
            //        if (!isparsed) Console.WriteLine("Invaild Input , Try Again.");
            //    } while (!isparsed || age <= 0);
            //    person[i].Age = age;

            //    oldest = (age > oldest.Age) ? person[i] : oldest;

            //}
            //Console.WriteLine($"Oldest Person: Name:{oldest.Name} , Age:{oldest.Age}");
            #endregion

        }
    }
}
