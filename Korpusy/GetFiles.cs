using System;
using System.Collections.Generic;
using System.IO;

namespace Korpusy
{
    internal class GetFiles
    {
        public IEnumerable<string> get()
        {
            var files = Directory.EnumerateFiles(@"C:\Users\Seba\Documents\!Studia\Nowy folder\Sofrep\","*.html",searchOption: SearchOption.AllDirectories);
           
            return files;
        }
    }
}