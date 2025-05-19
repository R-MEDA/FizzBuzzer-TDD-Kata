namespace FizzBuzzer.Tests
{
    public class FizzBuzzerTests
    {
        private readonly FizzBuzzer fizzBuzzer;

        public FizzBuzzerTests()
        {
            fizzBuzzer = new FizzBuzzer();
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void GivenNumberIsMultipleOfThree_WhenFizzBuzzerRuns_ThenReturnsFizz(int number)
        {
            string result = fizzBuzzer.FizzBuzz(number);

            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void GivenNumberIsMultipleOfFive_WhenFizzBuzzerRuns_ThenReturnsBuzz(int number)
        {
            string result = fizzBuzzer.FizzBuzz(number);

            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(90)]
        public void GivenNumberIsMultipleOfBothThreeAndFive_WhenFizzBuzzerRuns_ThenReturnsFizzBuzz(int number)
        {

            string result = fizzBuzzer.FizzBuzz(number);

            Assert.Equal("FizzBuzz", result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        public void GivenNumberIsNeitherMultipleOThreeNorFive_WhenFizzBuzzerRuns_ThenReturnsFizzBuzz(int number)
        {
            string result = fizzBuzzer.FizzBuzz(number);

            Assert.Equal(number.ToString(), result);
        }
    }
}