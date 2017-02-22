using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Xml;
using System.Security.Cryptography;

namespace JoePitt.PassGen.Generators
{
    public class WordsGenerator : IDisposable
    {
        private WebClient Client;
        private XmlDocument Reader;
        private string WordsPath;

        public WordsGenerator()
        {
            Client = new WebClient();
            Client.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            Reader = new XmlDocument();
            WordsPath = Properties.Words.Default.DictionaryPath;
        }

        public string Adjective()
        {
            if (Properties.Words.Default.AdjectiveFile)
            {
                List<string> adjectives = new List<string>();
                adjectives.AddRange(File.ReadAllLines(WordsPath + "Adjectives.txt"));
                RNGCryptoServiceProvider seeder = new RNGCryptoServiceProvider();
                byte[] seedBytes = new byte[4];
                seeder.GetBytes(seedBytes);
                int seed = BitConverter.ToInt32(seedBytes, 0);
                Random random = new Random(seed);
                return adjectives[random.Next(0, adjectives.Count)];
            }
            else
            {
                string Word = "";
                string Page = Client.DownloadString("http://www.randomlists.com/random-adjectives?random=" + DateTime.Now.Ticks);
                WebHeaderCollection test = Client.ResponseHeaders;
                int ListStart = Page.IndexOf("<ol id=\"result\">");
                int ListEnd = (Page.IndexOf("</ol>") + 5) - ListStart;
                Page = Page.Substring(ListStart, ListEnd);
                Reader.LoadXml(Page);
                foreach (XmlNode node in Reader.GetElementsByTagName("span"))
                {
                    if (node.Attributes["class"].Value == "crux")
                    {
                        Word = node.InnerText;
                        Word = Word.Substring(0, 1).ToUpper() + Word.Substring(1);
                        break;
                    }
                }
                return Word;
            }
        }

        public string Adverb()
        {
            if (Properties.Words.Default.AdverbFile)
            {
                List<string> adverbs = new List<string>();
                adverbs.AddRange(File.ReadAllLines(WordsPath + "Adverbs.txt"));
                RNGCryptoServiceProvider seeder = new RNGCryptoServiceProvider();
                byte[] seedBytes = new byte[4];
                seeder.GetBytes(seedBytes);
                int seed = BitConverter.ToInt32(seedBytes, 0);
                Random random = new Random(seed);
                return adverbs[random.Next(0, adverbs.Count)];
            }
            else
            {
                string Word = "";
                string Page = Client.DownloadString("http://www.randomlists.com/random-adverbs?random=" + DateTime.Now.Ticks);
                int ListStart = Page.IndexOf("<ol id=\"result\">");
                int ListEnd = (Page.IndexOf("</ol>") + 5) - ListStart;
                Page = Page.Substring(ListStart, ListEnd);
                Reader.LoadXml(Page);
                foreach (XmlNode node in Reader.GetElementsByTagName("span"))
                {
                    if (node.Attributes["class"].Value == "crux")
                    {
                        Word = node.InnerText;
                        Word = Word.Substring(0, 1).ToUpper() + Word.Substring(1);
                        break;
                    }
                }
                return Word;
            }
        }

        public string Noun()
        {
            if (Properties.Words.Default.NounFile)
            {
                List<string> nouns = new List<string>();
                nouns.AddRange(File.ReadAllLines(WordsPath + "Nouns.txt"));
                RNGCryptoServiceProvider seeder = new RNGCryptoServiceProvider();
                byte[] seedBytes = new byte[4];
                seeder.GetBytes(seedBytes);
                int seed = BitConverter.ToInt32(seedBytes, 0);
                Random random = new Random(seed);
                return nouns[random.Next(0, nouns.Count)];
            }
            else
            {
                string Word = "";
                string Page = Client.DownloadString("http://www.randomlists.com/nouns?random=" + DateTime.Now.Ticks);
                int ListStart = Page.IndexOf("<ol id=\"result\">");
                int ListEnd = (Page.IndexOf("</ol>") + 5) - ListStart;
                Page = Page.Substring(ListStart, ListEnd);
                Reader.LoadXml(Page);
                foreach (XmlNode node in Reader.GetElementsByTagName("span"))
                {
                    if (node.Attributes["class"].Value == "crux")
                    {
                        Word = node.InnerText;
                        Word = Word.Substring(0, 1).ToUpper() + Word.Substring(1);
                        break;
                    }
                }
                return Word;
            }
        }

        public string Verb()
        {
            if (Properties.Words.Default.VerbFile)
            {
                List<string> verbs = new List<string>();
                verbs.AddRange(File.ReadAllLines(WordsPath + "Verbs.txt"));
                RNGCryptoServiceProvider seeder = new RNGCryptoServiceProvider();
                byte[] seedBytes = new byte[4];
                seeder.GetBytes(seedBytes);
                int seed = BitConverter.ToInt32(seedBytes, 0);
                Random random = new Random(seed);
                return verbs[random.Next(0, verbs.Count)];
            }
            else
            {
                string Word = "";
                string Page = Client.DownloadString("http://www.randomlists.com/random-verbs?random=" + DateTime.Now.Ticks);
                int ListStart = Page.IndexOf("<ol id=\"result\">");
                int ListEnd = (Page.IndexOf("</ol>") + 5) - ListStart;
                Page = Page.Substring(ListStart, ListEnd);
                Reader.LoadXml(Page);
                foreach (XmlNode node in Reader.GetElementsByTagName("span"))
                {
                    if (node.Attributes["class"].Value == "crux")
                    {
                        Word = node.InnerText;
                        Word = Word.Substring(0, 1).ToUpper() + Word.Substring(1);
                        break;
                    }
                }
                return Word;
            }
        }

        public string Next(List<char> Format)
        {
            string Password = "";
            foreach (char WordType in Format)
            {
                switch (WordType)
                {
                    case 'A':
                        Password = Password + Adjective();
                        break;
                    case 'D':
                        Password = Password + Adverb();
                        break;
                    case 'N':
                        Password = Password + Noun();
                        break;
                    case 'V':
                        Password = Password + Verb();
                        break;
                }
            }
            return Password;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Client.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
