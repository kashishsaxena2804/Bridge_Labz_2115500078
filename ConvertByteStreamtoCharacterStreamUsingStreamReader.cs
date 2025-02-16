﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ReaderC
{
    //Method to read and count the word in file
    static void ReadAndShow(string path)
    {
        try
        {
            //Convert to binary as filestream give output in binary
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            //Using encoding to convert binary to char
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            {
                string content = sr.ReadToEnd();
                //Display output
                Console.WriteLine(content);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    //Main  method
    //static void Main()
    //{
    //    string filePath = "sample.txt";
    //    ReadAndShow(filePath);

    //}
}
