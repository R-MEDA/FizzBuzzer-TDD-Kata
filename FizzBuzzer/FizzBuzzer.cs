namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            var isDivisibleByFive = isDivisibleBy(5, number);
            var isDivisibleByThree = isDivisibleBy(3, number);

            if (isDivisibleByFive && isDivisibleByThree)
            {
                return "FizzBuzz";
            }
            else if (isDivisibleByFive)
            {
                return "Buzz";
            }
            else if (isDivisibleByThree)
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }

        private readonly Func<int, int, bool> isDivisibleBy = (number, numberUnderCheck) => numberUnderCheck % number == 0;
    }
}