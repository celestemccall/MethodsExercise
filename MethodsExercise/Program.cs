namespace MethodsExercise
{
    class Program
    {
        public static void HelloThere()
        {
            Console.WriteLine("Hello there! What is your first name?");
            var userName = Console.ReadLine();

        Console.WriteLine($"Nice to meet you {userName}! What is your favorite color?");
            var color = Console.ReadLine();

        Console.WriteLine($"{color} is my favorite color too! What's your favorite animal?");
            var animal = Console.ReadLine();

        Console.WriteLine($"That is so awesome {userName}, one last question, what is your favorite band?");
            var band = Console.ReadLine();

        Console.WriteLine($"It has been wonderful getting to know you {userName}, talk to you soon!");
        } 

    static void Main(string[] args)
        {
            HelloThere();

           
        }
    }
}
