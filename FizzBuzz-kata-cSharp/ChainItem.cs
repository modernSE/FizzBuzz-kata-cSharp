using System;

namespace FizzBuzz
{
    public abstract class ChainItem
    {
        public Predicate<int> Predicate { get; set; }
        public string AppendTranslation {get; set;}
        public ChainItem Next { get; set; }

        public virtual string Translate(string currentTranslation, int number)
        {
            if (Predicate(number))
            {
                currentTranslation += AppendTranslation;
            }
            return Next.Translate(currentTranslation, number);
        }
    }
}
