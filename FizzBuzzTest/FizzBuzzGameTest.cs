using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_givenNumber_When_Countoff_Given_normal_number()
        {
            //Given
            int input = 1;

            //When
            FizzBuzzGame game = new FizzBuzzGame();
            string output = game.CountOff(input);

            //Then
            Assert.Equal("1", output);
        }

        [Fact]
        public void Should_return_Fizz_When_Countoff_Given_normal_number()
        {
            //Given
            int input = 3;

            //When
            FizzBuzzGame game = new FizzBuzzGame();
            string output = game.CountOff(input);

            //Then
            Assert.Equal("Fizz", output);
        }

        [Fact]
        public void Should_output_Buzz_When_use_FizzBuzzGame_Given_input_five()
        {
            //Given
            int input = 5;

            //When
            FizzBuzzGame game = new FizzBuzzGame();
            string output = game.CountOff(input);

            //Then
            Assert.Equal("Buzz", output);
        }

        [Fact]
        public void Should_output_FizzBuzz_When_use_FizzBuzzGame_Given_input_fifteen()
        {
            //Given
            int input = 15;

            //When
            FizzBuzzGame game = new FizzBuzzGame();
            string output = game.CountOff(input);

            //Then
            Assert.Equal("FizzBuzz", output);
        }


    }
}