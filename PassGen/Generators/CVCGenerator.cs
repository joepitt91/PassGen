using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JoePitt.PassGen.Generators
{
    public class CVCGenerator
    {
        int Seed;
        string Cs = "BCDFGHJKLMNPQRSTVWXYZ";
        string Vs = "AEIOU";

        public CVCGenerator()
        {
            Seed = NewSeed();
        }

        private int NewSeed()
        {
            RNGCryptoServiceProvider SeedGen = new RNGCryptoServiceProvider();
            byte[] Seed = new byte[4];
            SeedGen.GetBytes(Seed);
            return BitConverter.ToInt32(Seed, 0);
        }

        public string Next(int Count)
        {
            // Convert to a char array.
            char[] CArray = Cs.ToCharArray();
            char[] VArray = Vs.ToCharArray();
            // Generate the password, using a cryptographically strong seed.
            Random Generator = new Random(Seed);
            string Password = "";
            int i = 0;
            while (i < Count)
            {
                Password = Password + 
                    CArray[Generator.Next(0, 21)] + 
                    VArray[Generator.Next(0, 5)] + 
                    CArray[Generator.Next(0, 21)] + "-";
                i++;
            }
            Password = Password.Substring(0, Password.Length - 1);
            Seed = NewSeed();
            // Return the generated password.
            return Password;
        }
    }
}
