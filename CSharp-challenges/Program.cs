
using CSharp_challenges.Functions;

class Program
{
    
    
     
    static void Main(string[] args)
    {

        string? projectType;
        Console.WriteLine("Welcome to my C# challenge project");

        Console.Write("Please enter a project type: ");
        projectType = Console.ReadLine();

        if (!string.IsNullOrEmpty(projectType)) 
        {
            switch (projectType.ToLower())
            {
                case "reverse string":
                    ReverseStrings reverseStrings = new ReverseStrings();

                    Console.Write("Please enter a string: ");
                    string? response = Console.ReadLine();

                    if (string.IsNullOrEmpty(response))
                    {
                        Console.WriteLine("No string was entered. Please enter a valid string to reverse.");
                        return;
                    }
                    string result = reverseStrings.ReverseString(response);
                    
                    Console.WriteLine($"Reversed string: {result}");
                    break;
                case "Prime number":
                    Console.WriteLine("This project type is not implemented yet.");
                    break;
                default:
                    Console.WriteLine("Invalid project type. Please enter one of the following: Reverse string, ");
                    break;
            }
        }
        else 
        {
            Console.WriteLine("You did not enter a valid project type.");
        }
    }
}   
