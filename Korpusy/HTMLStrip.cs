using System;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using ikvm.extensions;

namespace Korpusy
{
    internal class HTMLStrip

    {
        private readonly GetFiles pobierz = new GetFiles();

        private readonly ZapisywanieDoTxt teDoTxt = new ZapisywanieDoTxt();

        public void oczyść()
        {
            foreach (var p in pobierz.get())
            {
                var document = new HtmlWeb().Load(p);

                var text = document.DocumentNode.InnerHtml;

                Console.WriteLine(text.Length);

                if (text.indexOf("body1", 0) > 0 && text.lastIndexOf("relatedKeywords") > 0)
                {
                    text = text.substring(text.indexOf("body1", 0),
                        text.lastIndexOf("relatedKeywords"));

                    text = Regex.Replace(text, @"<[^>]+>|&nbsp;", "");

                    teDoTxt.Zapisz(@"C:\Users\Seba\Downloads\T.txt", text);
                }
            }
        }
    }
}