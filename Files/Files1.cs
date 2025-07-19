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
        string pathSelect = string.Empty;
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
                foreach(FileInfo file in files)
                {
                    pathSelect = file.FullName;
                    if (pathSelect.Contains(fileName))
                    {
                        fileName = pathSelect;
                        break;
                    }
                }
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                    Console.WriteLine($"Soubor {fileName} byl smazán.");
                    //FileInfo file = new FileInfo(fileName);
                    //file.Delete();
                }
                else
                {
                    Console.WriteLine("Soubor neexistuje.");
                }
            }
            else
            {
                Console.WriteLine("Soubor nebyl nalezen.");
            }
        }
    }

    public static void Run()
    {
        Files1 file = new Files1();
        file.Delete();
    }
}
