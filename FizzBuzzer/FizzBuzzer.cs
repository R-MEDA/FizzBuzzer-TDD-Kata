namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            if (number % 5 == 0)
            {
                return "Buzz";
            } else {
                return "Fizz";
            }
        }
    }
}