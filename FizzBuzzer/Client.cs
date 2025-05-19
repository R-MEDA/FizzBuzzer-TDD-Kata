namespace FizzBuzzer
{
    public class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I am a consumer of the FizzBuzzer :)");

            FizzBuzzer fizzBuzzer = new FizzBuzzer();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzzer.FizzBuzz(i));
            }
        }
    }
}