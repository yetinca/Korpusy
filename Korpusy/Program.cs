using Korpusy.Models;

namespace Korpusy
{
  internal class Program
    {
        private static void Main(string[] args)
        {
            var plik = new PDFProcessing();

            var txt = new ZapisywanieDoTxt();

            var bazunia = new KorpusyEntities();

      var pos = new SharpNlp();
      pos.Main();

      //bazunia.Database.ExecuteSqlCommand("delete from t1");


      //(new StringReader(File.ReadAllText(@"C:\Users\Seba\Documents\!Studia\Korpus.txt")))

      //  foreach (var i in plik.Wyrazy(System.IO.File.ReadAllText(@"C:\Users\Seba\Documents\!Studia\Korpus.txt")))
      //  {
      //      if (i.Length < 22 && i.Length > 0 && !i.All(char.IsDigit))

      //      {
      //          bazunia.Database.ExecuteSqlCommand("insert into t1(word, lenght) values('" + i.Trim() + "'," +
      //                                             i.Length + ")");
      //      }
      //      else
      //      {
      //System.Console.WriteLine(i);
      //      }
      //  }

    }
    }
}