﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExceptionPropogation
{
    public static void Method1()
    {
        throw new InvalidOperationException("An error occured in Method1");
    }

    public static void Method2()
    {
        Method1();
    }

    public static void Main(string[] args)
    {
        try
        {
            Method2();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Handled exception in Main: " + ex.Message);
        }
    }
}

