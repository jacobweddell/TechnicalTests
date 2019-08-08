using System;

namespace XN.TechnicalTest
{
    public class CharacterCounter
    {
        public int CountCharacters(string text, char characterToCount)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            int count = 0;
            foreach(var character in text.ToCharArray())
            {
                if (character == characterToCount)
                    count++;
            }

            return count;
            
        }

    }
}
