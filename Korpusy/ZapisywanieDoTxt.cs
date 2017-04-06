using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korpusy
{
    class ZapisywanieDoTxt
    {
        public void Zapisz(string path, string content)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                File.SetAttributes(path, FileAttributes.Normal);
                
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("-------------");
                tw.WriteLine(content);
                tw.Close();
            }
            else
            {
                using (StreamWriter tw = File.AppendText(path))
                {
                    Console.WriteLine(File.GetLastWriteTime(path));
                    tw.WriteLine("------------------------\n");
                    tw.WriteLine(content);
                    tw.Close();
                }
                //TextWriter tw = new StreamWriter(path);
                //Console.WriteLine( File.GetLastWriteTime(path));
                //tw.WriteLine("------------------------\n");
                //tw.WriteLine(content);
                //tw.Close();
            }
        }

        public FileInfo[] PobierzPliki(string path)
        {
            DirectoryInfo d = new DirectoryInfo(@path);
            FileInfo[] Files = d.GetFiles("*.pdf");
            return Files;
        }
    }
}
