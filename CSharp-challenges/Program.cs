
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

                case "prime number":

                    PrimeNumber primeNumber = new PrimeNumber();

                    Console.Write("Please enter a number: ");
                    string? primeNumberResponse = Console.ReadLine();

                    int number = 0;
                    try {
                        number = primeNumberResponse != null ? int.Parse(primeNumberResponse) : 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Please enter a valid integer. {ex.Message}");
                        return;
                    }

                    bool isPrime = primeNumber.IsPrime(number);

                    Console.WriteLine(isPrime ? $"{number} is a prime number" : $"{number} is not a prime number");
                    break;

                case "even odd":

                    EvenOrOdd evenOrOdd = new EvenOrOdd();

                    string? evenOrOddInput = Console.ReadLine();

                    int evenOrOddNumber = 0;
                    try
                    {
                        evenOrOddNumber = evenOrOddInput != null ? int.Parse(evenOrOddInput) : 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Please enter a valid integer. {ex.Message}");
                        return;
                    }
                    
                    bool isEven = evenOrOdd.IsEvenOrOdd(evenOrOddNumber);

                    Console.WriteLine($"{evenOrOddNumber} is ", isEven ? "even" : "odd");

                    break;

                case "count vowels":
                    CountVowels countVowels = new CountVowels();

                    Console.Write("Please enter a string: ");
                    string? countVowelsInput = Console.ReadLine();

                    if (string.IsNullOrEmpty(countVowelsInput))
                    {
                        Console.WriteLine("No string was entered. Please enter a valid string to count vowels.");
                        return;
                    }

                    int vowelCount = countVowels.CountVowelsInString(countVowelsInput);
                    Console.WriteLine($"Number of vowels in the string: {vowelCount}");

                    break;

                case "palindrome":
                    PalindromeCheck palindromeCheck = new PalindromeCheck();

                    Console.Write("Please enter a string: ");
                    string? palindromeInput = Console.ReadLine();

                    if (string.IsNullOrEmpty(palindromeInput))
                    {
                        Console.WriteLine("No string was entered. Please enter a valid string to check for palindrome.");
                        return;
                    }

                    bool isPalindrome = palindromeCheck.IsPalindrome(palindromeInput);
                    Console.WriteLine(isPalindrome ? $"{palindromeInput} is a palindrome" : $"{palindromeInput} is not a palindrome");

                    break;

                case "frequent character":
                    FrequentCharacterCheck frequentCharacterCheck = new FrequentCharacterCheck();
                    Console.WriteLine("Enter a string to check for the most frequent character:");

                    string? input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("No string was entered. Please enter a valid string to find the most frequent character.");
                    } else {
                        char mostFrequentChar = frequentCharacterCheck.CalculateFrequentCharacter(input);

                        Console.WriteLine($"The most frequent character is: {mostFrequentChar}");
                    }
                    break;

                case "find duplicates":
                    FindDuplicates findDuplicates = new FindDuplicates();

                    List<string> duplicatesInput = new List<string>();

                    Console.WriteLine("Enter the amount of items to enter:");

                    string? duplicateCountString = Console.ReadLine();

                    int duplicateCount = 0;
                    try
                    {
                        duplicateCount = duplicateCountString != null ? int.Parse(duplicateCountString) : 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Please enter a valid integer. {ex.Message}");
                        return;
                    }


                    for (int i = 0; i < duplicateCount; i++)
                    {
                        Console.Write($"Enter string {i + 1}: ");
                        string? inputString = Console.ReadLine();

                        if (string.IsNullOrEmpty(inputString))
                        {
                            Console.WriteLine("No string was entered. Please enter a valid string.");
                            return;
                        }
                        duplicatesInput.Add(inputString);
                    }

                    if (duplicatesInput.Count < 1)
                    {
                        Console.WriteLine("No string was entered. Please enter a valid string to find duplicates.");
                    } else {
                        var duplicates = findDuplicates.FindDuplicateCharacters(duplicatesInput);
                        if (duplicates.Count > 0)
                        {
                            Console.WriteLine($"Duplicate characters found: {string.Join(", ", duplicates)}");
                        }
                        else
                        {
                            Console.WriteLine("No duplicate characters found.");
                        }
                    }
                    break;
                case "calculator":
                    Calculator calculator = new Calculator();

                    Console.WriteLine("Enter the calculation you want calculated:");

                    string? calculatorInput = Console.ReadLine();

                    if (!string.IsNullOrEmpty(calculatorInput)) 
                    {
                        bool isCalculationValid = calculator.CheckCalculation(calculatorInput);

                        double calculationReturn = calculator.Calculate(calculatorInput);
                    }
                    else 
                    {
                        Console.WriteLine("No calculation was entered. Please enter a valid calculation.");
                    }

                    break;
                default:
                    Console.WriteLine("Invalid project type. Please enter one of the following: Reverse string, Prime number");
                    break;
            }
        }
        else 
        {
            Console.WriteLine("You did not enter a valid project type.");
        }
    }
}   
