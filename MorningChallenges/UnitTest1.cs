using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallenges
{
    [TestClass]
    public class W1D3
    {
        string challengeOne = "Supercalifragilisticexpialidocious";
        [TestMethod]
        public void Challenge()
        {
            foreach (char letter in challengeOne) { Console.WriteLine(letter); }
            { Console.WriteLine(challengeOne.Length); }


            foreach (char letter in challengeOne)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                if (letter == 'l')
                {
                    Console.WriteLine('L');
                }
                else
                {
                    Console.WriteLine("not an I");
                }
            }
        }
    }
}
