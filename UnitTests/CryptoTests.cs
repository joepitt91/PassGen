using JoePitt.PassGen.Generators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class CryptoTests
    {
        // Eight Char Crypto
        [TestMethod]
        public void Crypto_8Char_1Pass()
        {
            CryptoGenerator TestGenerator = new CryptoGenerator();
            Console.WriteLine(TestGenerator.Next(8, true, true, true, true, false, true));
        }

        [TestMethod]
        public void Crypto_8Char_10Pass()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 10)
            {
                CryptoGenerator TestGenerator = new CryptoGenerator();
                Passwords.Add(TestGenerator.Next(8, true, true, true, true, false, true));
                Console.WriteLine(Passwords[i]);
                i++;
            }

            if (Passwords.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Assert.Fail("Duplicates found");
            }
        }

        [TestMethod]
        public void Crypto_8Char_100Pass()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 100)
            {
                CryptoGenerator TestGenerator = new CryptoGenerator();
                Passwords.Add(TestGenerator.Next(8, true, true, true, true, false, true));
                Console.WriteLine(Passwords[i]);
                i++;
            }

            if (Passwords.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Assert.Fail("Duplicates found");
            }
        }

        // 64 Char Crypto
        [TestMethod]
        public void Crypto_64Char_1Pass()
        {
            CryptoGenerator TestGenerator = new CryptoGenerator();
            Console.WriteLine(TestGenerator.Next(64, true, true, true, true, false, true));
        }

        [TestMethod]
        public void Crypto_64Char_10Pass()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 10)
            {
                CryptoGenerator TestGenerator = new CryptoGenerator();
                Passwords.Add(TestGenerator.Next(64, true, true, true, true, false, true));
                Console.WriteLine(Passwords[i]);
                i++;
            }

            if (Passwords.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Assert.Fail("Duplicates found");
            }
        }

        [TestMethod]
        public void Crypto_64Char_100Pass()
        {
            List<string> Passwords = new List<string>();
            int i = 0;
            while (i < 100)
            {
                CryptoGenerator TestGenerator = new CryptoGenerator();
                Passwords.Add(TestGenerator.Next(64, true, true, true, true, false, true));
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
