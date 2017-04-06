using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korpusy.Models
{
  public class SharpNlp

  {
    public string mModelPath = @"C:/Users/Seba/Documents/Visual Studio 2017/Projects/Korpusy/Korpusy/Models/EnglishPOS.nbin";

    public mPosTagger = new OpenNLP.Tools.PosTagger.EnglishMaximumEntropyPosTagger(mModelPath + "EnglishPOS.nbin", mModelPath + @"/Parser/tagdict");
  }
}
