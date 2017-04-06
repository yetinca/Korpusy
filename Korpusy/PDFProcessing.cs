using System;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;

namespace Korpusy
{
    internal class PDFProcessing
    {
        public string TextFromPDF(string plik)

        {
            var text = string.Empty;


            var reader = new PdfReader(plik);

            for (var page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();


            return text;
        }

        // public string CzytaniePdf(string plik)
        //{
        //     PdfReader pdfReader=new PdfReader(plik);
        //     for (int page = 1; page <= pdfReader.NumberOfPages; page++)
        //     {
        //         ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
        //         strategy.RenderText();
        //         string currentPageText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

        //     }
        //     pdfReader.Close();

        //     return
        // }

        public string PdfBoks(string plik)
        {
            PDDocument doc = null;
            try
            {
                doc = PDDocument.load(plik);

                var stripper = new PDFTextStripper();

                stripper.setSpacingTolerance(0.2f);

                return stripper.getText(doc);
            }
            finally
            {
                if (doc != null)
                {
                    doc.close();
                }
            }
        }

        public string[] Wyrazy(string pdfText)
        {
            string[] separatory =
            {
                "•", " ", ",", ".", "/", "//", "\n", "\r", "'", "\r\n", ":", ";", "(", ")", "[", "]",
                "{", "}", "-", "=", "+", "*", "<", ">", "?", "!", "\'", "@", "#", "$", "%", "^", "&", "\\"
            };

            var tabela = pdfText.Split(separatory, StringSplitOptions.None);

            return tabela;
        }
    }
}