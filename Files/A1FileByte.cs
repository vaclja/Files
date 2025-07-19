using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class A1FileByte
    {
        public void writeByte()
        {
            string path = @"C:\Users\rewit\Downloads\File";
            string filePath = @"C:\Users\rewit\Downloads\File\file.txt";
            Byte dny = 30;
            Byte hodiny = 20;
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                FileInfo file = new FileInfo(filePath);
                if(file.Exists)
                {
                    file.Delete();
                    Console.WriteLine("Soubor existoval, tak jsem ho smazal.");
                }
                else
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Create(filePath)))
                    {
                        Console.WriteLine("Soubor neexistoval, tak jsem ho založil.");
                        writer.Write((dny*24)+hodiny);
                    }
                        
                    using(BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                    {
                        try
                        {
                            string content = reader.ReadInt32().ToString();
                            Console.WriteLine("Obsah souboru: " + content);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Složka neexistuje.");
            }
        }
        public static void Run()
        {
            A1FileByte a1FileByte = new A1FileByte();
            a1FileByte.writeByte();
        }
    }
}
