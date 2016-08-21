using JoePitt.PassGen.Generators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class CVCTests
    {
        // 3 part CVC
        [TestMethod]
        public void One_ThreePartCVC()
        {
            CVCGenerator TestGenerator = new CVCGenerator();
            Console.WriteLine(TestGenerator.Next(3));
        }

        [TestMethod]
        public void Ten_ThreePartCVC()
        {
            int i = 0;
            while (i < 10)
            {
                CVCGenerator TestGenerator = new CVCGenerator();
                Console.WriteLine(TestGenerator.Next(3));
                i++;
            }
        }

        [TestMethod]
        public void OneHundred_ThreePartCVC()
        {
            int i = 0;
            while (i < 100)
            {
                CVCGenerator TestGenerator = new CVCGenerator();
                Console.WriteLine(TestGenerator.Next(3));
                i++;
            }
        }

        //10 part CVC
        [TestMethod]
        public void One_TenPartCVC()
        {
            CVCGenerator TestGenerator = new CVCGenerator();
            Console.WriteLine(TestGenerator.Next(10));
        }

        [TestMethod]
        public void Ten_TenPartCVC()
        {
            int i = 0;
            while (i < 10)
            {
                CVCGenerator TestGenerator = new CVCGenerator();
                Console.WriteLine(TestGenerator.Next(10));
                i++;
            }
        }

        [TestMethod]
        public void OneHundred_TenPartCVC()
        {
            int i = 0;
            while (i < 100)
            {
                CVCGenerator TestGenerator = new CVCGenerator();
                Console.WriteLine(TestGenerator.Next(10));
                i++;
            }
        }
    }
}
