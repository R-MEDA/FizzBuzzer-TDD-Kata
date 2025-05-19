namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            var result = "";

            var isDivisibleByFive = isDivisibleBy(5, number);
            var isDivisibleByThree = isDivisibleBy(3, number);

            if (isDivisibleByThree)
            {
                result += "Fizz";
            }
            if (isDivisibleByFive)
            {
                result += "Buzz";
            }
            else if(result == "")
            {
                result = number.ToString();
            }

            return result;
        }

        private readonly Func<int, int, bool> isDivisibleBy = (number, numberUnderCheck) => numberUnderCheck % number == 0;
    }
}