using System;
using System.Collections.Generic;

namespace ConsoleAppLesson5
{
    class Program
    {
        enum MovieRatings
        {
            Terrible = 0,
            Bad = 1,
            OK = 2,
            PrettyGood = 3,
            ReallyGood = 4,
            Great = 5,
            BestMovieEver = 6
            //Empty = -1
        }

        struct Actor
        {
            public int actor_id;
            public string first_name;
            public string last_name;
            public DateTime last_update;
        }

        struct MovieData
        {
            public string MovieName;
            public MovieRatings rating;
            public bool myFavoriteMovie;
        }



        static void Main(string[] args)
        {


            MovieRatings rating = MovieRatings.Bad;
            if (rating == MovieRatings.Terrible)
            {
                Console.WriteLine("Worst movie I've ever seen!");

            }
            else if (rating == MovieRatings.BestMovieEver)
            {
                Console.WriteLine("It was the best movie ever!");
            }
            else
            {
                Console.WriteLine("Well, it wasn't the worst movie ever, but it wasn't the best either.");
            }

            Console.WriteLine("This statement after the IF will always run.");

            foreach (var item in collection)
            {

            }


        }

     
    }
}
