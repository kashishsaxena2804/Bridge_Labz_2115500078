using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HandlingFileNotFoundException
{
    public static void Main(string[] args)
    {
        string filePath = "data.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine("Data");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("file not found");
        }

        catch (IOException ex)
        {
            Console.WriteLine("An IO error acccured " + ex.Message);
        }
    }
}
