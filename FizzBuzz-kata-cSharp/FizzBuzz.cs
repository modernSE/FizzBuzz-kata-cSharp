namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Translate(int number)
        {
            if (number % 5 == 0 && number % 7 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 5 == 0)
            {
                return "Fizz";
            }
            if (number % 7 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}
