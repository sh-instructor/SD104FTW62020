using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.IO;


namespace ConsoleAppLesson8
{
    class Program
    {
        static void Main(string[] args)
        {


            Calculations myObj = new Calculations();

         int result =  myObj.Add(5, 6);

         string strResult = myObj.Add("Hello", "World");

     
            
            




        }
    }

    public class Calculations
    {


        public int Add(int x, int y)
        {


            return x + y;
        
        
        }


        public int Add(int x, int y, int z)
        {


            return x + y + z;


        }


        public string Add(string x, string y)
        {


            return x + y;


        }







    }




}
