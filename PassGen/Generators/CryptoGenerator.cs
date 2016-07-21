using System;
using System.Security.Cryptography;

namespace JoePitt.PassGen.Generators
{
    public class CryptoGenerator
    {
        /// <summary>
        /// Generates a cryptographically strong seed for the Random class.
        /// </summary>
        /// <returns>The cryptographically strong seed.</returns>
        private int NewSeed()
        {
            RNGCryptoServiceProvider SeedGen = new RNGCryptoServiceProvider();
            byte[] Seed = new byte[4];
            SeedGen.GetBytes(Seed);
            return BitConverter.ToInt32(Seed, 0);
        }

        /// <summary>
        /// Generates a password using a cryptographically strong seed and the defined character set.
        /// </summary>
        /// <param name="length">The number of characters to be generated.</param>
        /// <param name="lower">If the a-z character set is to be used.</param>
        /// <param name="upper">If the A-Z character set is to be used.</param>
        /// <param name="number">If the 0-9 character set is to be used.</param>
        /// <param name="special">If the Special Characters character set is to be used.</param>
        /// <param name="space">If the space character set is to be used.</param>
        /// <param name="requireAll">If all the enabled character sets must be present.</param>
        /// <returns></returns>
        public string Next(int length, bool lower, bool upper, bool number, bool special, bool space, bool requireAll)
        {
            // Define ASCII Character Set in groups.
            string lowerSet = "abcdefghijklmnopqrstuvwxyz";
            string upperSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numberSet = "0123456789";
            string specialSet = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            string spaceSet = " ";

            // Compile the character set to be used.
            string CharSetString = "";
            if (lower)      { CharSetString = CharSetString + lowerSet;     }
            if (upper)      { CharSetString = CharSetString + upperSet;     }
            if (number)     { CharSetString = CharSetString + numberSet;    }
            if (special)    { CharSetString = CharSetString + specialSet;   }
            if (space)      { CharSetString = CharSetString + spaceSet;     }

            // Convert to a char array.
            char[] CharSet = CharSetString.ToCharArray();
            int CharSetLength = CharSet.Length;

            Generate:
            // Generate the password, using a cryptographically strong seed.
            Random Generator = new Random(NewSeed());
            string Password = "";
            int i = 0;
            while (i < length)
            {
                Password = Password + CharSet[Generator.Next(0, CharSetLength)];
                i++;
            }

            // If all character sets are required, check they are all present.
            if (requireAll)
            {
                if (lower)
                {
                    if (Password.IndexOfAny(lowerSet.ToCharArray()) == -1)
                    {
                        goto Generate;
                    }
                }
                if (upper)
                {
                    if (Password.IndexOfAny(upperSet.ToCharArray()) == -1)
                    {
                        goto Generate;
                    }
                }
                if (number)
                {
                    if (Password.IndexOfAny(numberSet.ToCharArray()) == -1)
                    {
                        goto Generate;
                    }
                }
                if (special)
                {
                    if (Password.IndexOfAny(specialSet.ToCharArray()) == -1)
                    {
                        goto Generate;
                    }
                }
                if (space)
                {
                    if (Password.IndexOfAny(spaceSet.ToCharArray()) == -1)
                    {
                        goto Generate;
                    }
                }
            }

            // Return the generated password.
            return Password;
        }
    }
}
