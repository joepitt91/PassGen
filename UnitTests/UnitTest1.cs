using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoePitt.PassGen;
using JoePitt.PassGen.Generators;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UniquePasswords_10()
        {
            int count = 10;
            List<string> Passwords = new List<string>();
            int i = 0;
            while (Passwords.Count < count)
            {
                string password = CryptoGenerator.Next(8, true, true, true, true, true, true);
                if (!Passwords.Contains(password))
                {
                    Passwords.Add(password);
                }
                i++;
            }
            Console.WriteLine(count + " Unique Passwords Generated after " + i + " cycles.");
            if (i > count)
            {
                int duplicates = i - count;
                throw new Exception(duplicates + " duplicates detected while generating " + count + " Passwords");
            }
        }

        [TestMethod]
        public void UniquePasswords_100()
        {
            int count = 100;
            List<string> Passwords = new List<string>();
            int i = 0;
            while (Passwords.Count < count)
            {
                string password = CryptoGenerator.Next(8, true, true, true, true, true, true);
                if (!Passwords.Contains(password))
                {
                    Passwords.Add(password);
                }
                i++;
            }
            Console.WriteLine(count + " Unique Passwords Generated after " + i + " cycles.");
            if (i > count)
            {
                int duplicates = i - count;
                throw new Exception(duplicates + " duplicates detected while generating " + count + " Passwords");
            }
        }

        [TestMethod]
        public void UniquePasswords_1000()
        {
            int count = 1000;
            List<string> Passwords = new List<string>();
            int i = 0;
            while (Passwords.Count < count)
            {
                string password = CryptoGenerator.Next(8, true, true, true, true, true, true);
                if (!Passwords.Contains(password))
                {
                    Passwords.Add(password);
                }
                i++;
            }
            Console.WriteLine(count + " Unique Passwords Generated after " + i + " cycles.");
            if (i > count)
            {
                int duplicates = i - count;
                throw new Exception(duplicates + " duplicates detected while generating " + count + " Passwords");
            }
        }

        [TestMethod]
        public void UniquePasswords_10000()
        {
            int count = 10000;
            List<string> Passwords = new List<string>();
            int i = 0;
            while (Passwords.Count < count)
            {
                string password = CryptoGenerator.Next(8, true, true, true, true, true, true);
                if (!Passwords.Contains(password))
                {
                    Passwords.Add(password);
                }
                i++;
            }
            Console.WriteLine(count + " Unique Passwords Generated after " + i + " cycles.");
            if (i > count)
            {
                int duplicates = i - count;
                throw new Exception(duplicates + " duplicates detected while generating " + count + " Passwords");
            }
        }

        [TestMethod]
        public void UniquePasswords_100000()
        {
            int count = 100000;
            List<string> Passwords = new List<string>();
            int i = 0;
            while (Passwords.Count < count)
            {
                string password = CryptoGenerator.Next(8, true, true, true, true, true, true);
                if (!Passwords.Contains(password))
                {
                    Passwords.Add(password);
                }
                i++;
            }
            Console.WriteLine(count + " Unique Passwords Generated after " + i + " cycles.");
            if (i > count)
            {
                int duplicates = i - count;
                throw new Exception(duplicates + " duplicates detected while generating " + count + " Passwords");
            }
        }
    }
}
