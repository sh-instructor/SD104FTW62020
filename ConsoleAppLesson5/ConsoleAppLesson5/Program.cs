using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace ConsoleAppLesson5
{
    class Program
    {




        static void Main(string[] args)
        {


            CoffeeMug mug1 = new CoffeeMug("white","red","Worlds Best Daddy", 15);

            Console.WriteLine(mug1);



        }
       
    }


    class CoffeeMug

    { 
    
    private string color { get; set; }
    private string textcColor { get; set; }
    private string phrase { get; set; }
    private int size { get; set; }

        




        public CoffeeMug(string color, string textcColor, string phrase, int size)
        {
            this.color = color;
            this.textcColor = textcColor;
            this.phrase = phrase;
            this.size = size;
        }

    }





}
