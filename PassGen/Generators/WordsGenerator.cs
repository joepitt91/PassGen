using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Xml;

namespace JoePitt.PassGen.Generators
{
    public class WordsGenerator
    {
        private WebClient Client { get; set; }
        private XmlDocument Reader { get; set; }
        public bool AdjectivesFile { get; private set; }
        public bool AdverbsFile { get; private set; }
        public bool NounsFile { get; private set; }
        public bool VerbsFile { get; private set; }


        public WordsGenerator()
        {
            Client = new WebClient();
            Client.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            Reader = new XmlDocument();
            AdjectivesFile = File.Exists("\\Adjecrtives.txt");
            AdverbsFile = File.Exists("\\Adverbs.txt");
            NounsFile = File.Exists("\\Nouns.txt");
            VerbsFile = File.Exists("\\Verbs.txt");
        }

        public string Adjective()
        {
            if (AdjectivesFile)
            {
                return "ADJECTIVE-HERE";
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
            if (AdverbsFile)
            {
                return "ADVERB-HERE";
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
            if (NounsFile)
            {
                return "NOUN-HERE";
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
            if (VerbsFile)
            {
                return "VERB-HERE";
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
    }
}
