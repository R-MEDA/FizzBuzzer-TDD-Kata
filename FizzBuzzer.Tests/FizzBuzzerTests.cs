namespace FizzBuzzer.Tests;

public class FizzBuzzerTest
{
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void GivenNumberIsMultipleOfThree_WhenFizzBuzzerRuns_ThenReturnsFizz(int number)
    {
        FizzBuzzer fizzBuzzer = new FizzBuzzer();

        string result = fizzBuzzer.FizzBuzz(number);

        Assert.Equal("Fizz", result);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(15)]
    [InlineData(20)]
    public void GivenNumberIsMultipleOfFive_WhenFizzBuzzerRuns_ThenReturnsBuzz(int number)
    {
        FizzBuzzer fizzBuzzer = new FizzBuzzer();

        string result = fizzBuzzer.FizzBuzz(number);

        Assert.Equal("Buzz", result);
    }
}
