using edu.stanford.nlp.ling;
using edu.stanford.nlp.tagger.maxent;
using java.io;
using java.util;
using Console = System.Console;

namespace Korpusy.Models
{
  public class SharpNlp
  

  
    {
      public void Main()
      {
        var jarRoot = @"G:\ASP\stanford-postagger-full-2016-10-31";
        var modelsDirectory = jarRoot + @"\models";
        // Loading POS Tagger
        var tagger = new MaxentTagger(modelsDirectory + @"\wsj-0-18-bidirectional-nodistsim.tagger");
      // Text for tagging
      var text = System.IO.File.ReadAllText(@"C:\Users\Seba\Documents\!Studia\Korpus.txt");
        var sentences = MaxentTagger.tokenizeText(new StringReader(text)).toArray();
        foreach (ArrayList sentence in sentences)
        {
          var taggedSentence = tagger. tagSentence(sentence);
        //  Console.WriteLine(SentenceUtils.listToString(taggedSentence, false));
        //Console.ReadLine();
        }
      }
    }
  }


