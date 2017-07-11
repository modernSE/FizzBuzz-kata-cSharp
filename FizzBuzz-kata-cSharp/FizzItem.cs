namespace FizzBuzz
{
    public class FizzItem : ChainItem
    {
        public FizzItem(ChainItem next)
        {
            Next = next;
            Predicate = (x) => x % 5 == 0;
            AppendTranslation = "Fizz";
        }
    }
}
