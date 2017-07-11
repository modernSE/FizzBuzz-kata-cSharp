namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Translate(int number)
        {
            var chain = ChainFactory.Make();
            return chain.Translate(string.Empty, number);
        }
    }
}
