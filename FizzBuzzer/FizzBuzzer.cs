using System.Text;

namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        private readonly Dictionary<int, string> rules = new()
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

        public string FizzBuzz(int number)
        {
            var result = new StringBuilder();

            foreach (var rule in rules)
            {
                if (number % rule.Key == 0)
                {
                    result.Append(rule.Value);
                }
            }

            return result.Length > 0 ? result.ToString() : number.ToString();
        }
    }
}