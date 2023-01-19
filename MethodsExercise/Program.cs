namespace MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

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

        Console.WriteLine($"It has been wonderful getting to know you {userName}, here is your profile!");

            Console.WriteLine("----------------------------------------------------");


            Console.WriteLine($"Name:{userName}");
            Console.WriteLine($"Favorite Color:{color}");
            Console.WriteLine($"Favorite Animal:{animal}");
            Console.WriteLine($"Favorite Band:{band}");




        }

    static void Main(string[] args)
        {
            var amoutnOfCoins = Sum(2, 4);
            var amoutOfDollars = Sub(55, 25);
            var amountOfCandy = Multiply(30, 40);
            var amountOfTime = Divide(60, 20);




            HelloThere();

           
        }
    }
}
