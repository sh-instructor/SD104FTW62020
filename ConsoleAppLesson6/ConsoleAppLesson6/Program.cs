using System;

namespace ConsoleAppLesson6
{
    class Program
    {
        static void Main(string[] args)
        {

            int y = 2;
              y = AddNum(y);

            Console.WriteLine(y);


        }


        static public int AddNum(int x)
        {
            x += 3;

            return x;

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
