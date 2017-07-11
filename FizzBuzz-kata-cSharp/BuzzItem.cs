namespace FizzBuzz
{
    public class BuzzItem : ChainItem
    {
        public BuzzItem(ChainItem next)
        {
            Next = next;
            Predicate = (x) => x % 7 == 0;
            AppendTranslation = "Buzz";
        }
    }
}
