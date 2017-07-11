namespace FizzBuzz
{
    public class ChainFactory
    {
        public static ChainItem Make()
        {
            var sink = new SinkChainItem();
            var buzz = new BuzzItem(sink);
            var fizz = new FizzItem(buzz);
            return fizz;
        }
    }
}
