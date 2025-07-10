using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files;

internal class Files1
{
    public void Delete()
    {
        string path = @"C:\Users\rewit\Downloads\File";
        DirectoryInfo dir = new DirectoryInfo(path);
        if (dir.Exists)
        {
            FileInfo[] files = dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"Název souboru {file.FullName}");
               
            }
            Console.WriteLine("Který soubor se má smazat?");
            string fileName = Console.ReadLine();
            if (fileName != null)
            {
                File.Delete(fileName);
                Console.WriteLine($"Soubor {fileName} byl smazán.");
            }
            else
            {
                Console.WriteLine("Soubor nebyl nalezen.");
            }
        }
    }
    public static void Mainx(string[] args)
    {
        Files1 file = new Files1();
        file.Delete();
    }
}
