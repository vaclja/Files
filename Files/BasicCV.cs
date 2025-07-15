using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files;
    internal class A1FileStr
    {
    public void readFromFile()
    {
        string line = "";
        var number = new List<int>();
        int index = 0;
        int numberOfHourse, numberOfDays;
        string path = @"C:\Users\rewit\Downloads\File";
        DirectoryInfo dir = new DirectoryInfo(path);
        if (dir.Exists)
        {
            FileInfo file = new FileInfo(Path.Combine(path, "datetime.txt"));
            if (file.Exists)
            {
                using (StreamReader reader = new StreamReader(file.FullName))
                {
                    line = reader.ReadLine();
                }
            }
            if (line != "" && line != null)
            {
                string[] lineArray = line.Split(' ');
                foreach (string oneline in lineArray)
                {
                    Console.WriteLine(oneline);
                    try
                    {

                        if (int.TryParse(oneline, out int num))
                        {
                            number.Add(num);
                        }
                        else
                        {
                            Console.WriteLine($"Není to číslo {oneline}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Chyba při zpracování čísla: {ex.Message}");
                    }
                }
                    if (number != null && number.Count >= 2)
                    {
                        numberOfHourse = number[1];
                        numberOfDays = number[0];
                        Console.WriteLine($"Počet hodin: {numberOfHourse}, Počet dní: {numberOfDays}, celkem je to {(numberOfDays * 24) + numberOfHourse} hodin");
                    }
                    else
                    
                        Console.WriteLine("Nebylo možné získat počet hodin a dní.");
                    }
                
            }
        }
    
            
        public static void Mainx(string[] args)
        {
            A1FileStr fileStr = new A1FileStr();
            fileStr.readFromFile();
        }
    }
