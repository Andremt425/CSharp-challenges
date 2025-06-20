
class Program
{
    static void Main(string[] args)
    {

        string? projectType;
        Console.WriteLine("Welcome to my C# challenge project");

        projectType = Console.ReadLine();

        if (!string.IsNullOrEmpty(projectType)) 
        {
            Console.WriteLine($"You entered: {projectType}");
        }
        else 
        {
            Console.WriteLine("You did not enter a valid project type.");
        }
    }
}   
