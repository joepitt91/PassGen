using JoePitt.PassGen.Generators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class WordsTests
    {
        List<char> WordsFormat = new List<char>() { 'D', 'A', 'N' };

        [TestMethod]
        public void Words_1Pass()
        {
            WordsGenerator TestGenerator = new WordsGenerator();
            Console.WriteLine(TestGenerator.Next(WordsFormat));
        }

        [TestMethod]
        public void Words_10Pass()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 10)
            {
                WordsGenerator TestGenerator = new WordsGenerator();
                Passwords.Add(TestGenerator.Next(WordsFormat));
                Console.WriteLine(Passwords[i]);
                i++;
            }

            if (Passwords.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Assert.Fail("Duplicates found");
            }
        }

        [TestMethod]
        public void Words_100Pass()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 100)
            {
                WordsGenerator TestGenerator = new WordsGenerator();
                Passwords.Add(TestGenerator.Next(WordsFormat));
                Console.WriteLine(Passwords[i]);
                i++;
            }

            if (Passwords.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Assert.Fail("Duplicates found");
            }
        }
    }
}
