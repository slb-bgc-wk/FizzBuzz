namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string CountOff(int num)
        {
            string output = string.Empty;
            if (num % 3 == 0)
            {
                output += "Fizz";
            }

            if (num % 5 == 0)
            {
                output += "Buzz";
            }

            return output.Length == 0 ? num.ToString() : output;
        }
    }
}
