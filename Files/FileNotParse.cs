using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class FileNotParse
    {
        public void FileWithoutParse()
        {
            string path = @"C:\Users\rewit\Downloads\File";
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo file = new FileInfo(Path.Combine(path, "text.txt"));
            string obsah;

            if (dir.Exists)
            {
                if (!file.Exists)
                {
                    file.Create().Close();
                }
                else
                {
                    Console.WriteLine($"Soubor {file.Name} již existuje.");
                }
                using (StreamWriter writer = new StreamWriter(file.FullName))
                {
                    writer.WriteLine("Toto je testovací soubor.");
                };
                using (StreamReader reader = new StreamReader(file.FullName))
                {
                     obsah = reader.ReadToEnd();
                };
                Console.WriteLine(obsah);
            }
        } 
        public static void Mainx(string[] args)
        {
            FileNotParse fileNotParse = new FileNotParse();
            fileNotParse.FileWithoutParse();
        }
    }
}
