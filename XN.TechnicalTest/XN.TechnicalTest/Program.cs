using System;

namespace XN.TechnicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.";
            const string number = "17272838119191929838299111";

            var characterCounter = new CharacterCounter();

            var numberOfEs = characterCounter.CountCharacters(sentence, 'e');
            Console.WriteLine($"Occurences of 'e': {numberOfEs}");

            var numberOf1s = characterCounter.CountCharacters(number, '1');
            Console.WriteLine($"Occurences of '1': {numberOf1s}");

            var calculator = new Calculator();

            var result = calculator.Add(7, 5);

            Console.WriteLine($"7 + 5: {result}");

            Console.ReadLine();
        }
    }
}
