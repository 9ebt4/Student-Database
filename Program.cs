using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

string[] students = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };
string[] hometown = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };
string[] food = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

Console.WriteLine("Welcome to the student database. \b");


bool loop = true;
do
{
    int i = 1;
    foreach (string s in students)
    {
        Console.WriteLine($"{i} {s}");
        i++;
    }
    int selectStudent = 0;
    while (true)
    {
        Console.WriteLine("Would you like to use names or numbers?");
        string nameNumber = Console.ReadLine().ToLower().Trim();
        if (nameNumber == "names" || nameNumber == "name")
        {
            bool loop2 = true;
            while (loop2)
            {
                Console.WriteLine("Please enter the name you would like to find.");
                string studentName = Console.ReadLine().ToLower().Trim();
                i = 0;
                foreach(string s in students)
                {
                    if (s.ToLower().Trim() == studentName)
                    {
                        selectStudent = i;
                        loop2 = false;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (loop2 == true)
                {
                    Console.WriteLine("Please check spelling and spacing.");
                }
            }
            break;
        }
        else if (nameNumber == "numbers" || nameNumber == "number")
        {
            do
            {
                Console.WriteLine("Please enter a number.");
                selectStudent = int.Parse(Console.ReadLine().Trim()) - 1;
                if (selectStudent > students.Length && selectStudent < -1)
                {
                    Console.WriteLine($"Please enter a number between 1-{students.Length}.");
                }
            } while (selectStudent > students.Length && selectStudent < -1);
            break;
        }
        else
        {
            
        }
    }
    do
    {
        Console.WriteLine($"You have selected {students[selectStudent]}. Would you like to know their favorite food, hometown or both?");
        string answer = Console.ReadLine().ToLower().Trim();
        if (answer == "favorite food" || answer == "food" || answer == "f")
        {
            Console.WriteLine($"{students[selectStudent]}'s favorite food is {food[selectStudent]}.");
            break;
        }
        if (answer == "hometown" || answer == "home" || answer == "h" || answer == "town")
        {
            Console.WriteLine($"{students[selectStudent]}'s hometown is {hometown[selectStudent]}.");
            break;
        }
        if (answer == "both" || answer == "b")
        {
            Console.WriteLine($"{students[selectStudent]}'s favorite food is {food[selectStudent]} and their hometown is {hometown[selectStudent]}.");
            break;
        }
        else
        {
            Console.WriteLine("Please specify favorite food, hometown or both.");
        }
    } while (true);
    while (true)
    {
        Console.WriteLine("Would you like to view another student?");
        string affirm = Console.ReadLine().ToLower().Trim();
        if(affirm == "yes"|| affirm == "y"||affirm == "yep" || affirm == "yeah")
        {
            break;
        }
        if (affirm == "no" || affirm == "n" || affirm == "nope" || affirm == "nah")
        {
            loop = false;
            break;
        }
        else
        {
            Console.WriteLine("Please enter yes or no.");
        }
        
    }
} while (loop);
Console.WriteLine("Thank you for using student database. Have a good day.");

