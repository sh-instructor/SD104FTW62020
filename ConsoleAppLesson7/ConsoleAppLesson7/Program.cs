using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime;

namespace ConsoleAppLesson7
{
    class Program
    {

        public static ClassA classAObject;
        public static ClassB classBObject;

        static void Main(string[] args)
        {

            Messages myMessage;




            List<string> mylist = new List<string>();

            string[] myarray = {"val","val2" };
            string myVal = Array.Find(;

            classAObject = new ClassA();
            classBObject = new ClassB();
            classBObject.SeemsHarmless();

            Console.WriteLine(classAObject.state);

            WithEncap exampleObject = new WithEncap();
            exampleObject.notProtected = -50;
            //Program Class directly updates the public, unprotected property.
            exampleObject.UpdatePrivateProperty(4);



        }
    }

    class Messages
    {

        public string MessageTitle { get; set; }


    }
    class ClassA
    {
        public int state = 1;

    }

    class ClassB
    {


        public void SeemsHarmless()
        {
            ClassA classAObject = Program.classAObject;
            classAObject.state = 100;
        }

    }


    class WithEncap
    {
        public int notProtected;  //not protected by Encapsulation
        private int isProtected; // is protected from other classes 

        public WithEncap()
        {
            notProtected = 1;
            isProtected = 1;
        }

        public void UpdatePrivateProperty(int newValue)  //if you want to change my protected value, you must use this.
        {
            if (newValue < 0)
            {
                isProtected = newValue;
            }
          


            //I won't let you set it to a negative number.
        }

    }

}
