namespace FizzBuzz
{
    public class SinkChainItem : ChainItem
    {
        public SinkChainItem()
        { }

        public override string Translate(string currentTranslation, int number)
        {
            return string.IsNullOrEmpty(currentTranslation)
                    ? number.ToString()
                    : currentTranslation;
        }
    }
}
