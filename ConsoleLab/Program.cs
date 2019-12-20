using ConsoleLab.MovieStuff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleLab
{
    class Program
    {
        public static void Main(string[] args)
        {
            //MovieSortByWeight sortByWeight = new MovieSortByWeight();

            //var movieList = sortByWeight.moviesWithWeights;

            //movieList.ForEach(m => Console.WriteLine(m.Name));

            //Viewer Ted = new Viewer();
            //Viewer Claire = new Viewer();

            ////MovieSortByWeight.AdjustWeights(Ted, movieList[0]);
            ////MovieSortByWeight.AdjustWeights(Ted, movieList[1]);
            ////MovieSortByWeight.AdjustWeights(Ted, movieList[2]);
            ////MovieSortByWeight.AdjustWeights(Ted, movieList[4]);
            ////MovieSortByWeight.AdjustWeights(Ted, movieList[5]);

            //foreach (var movie in movieList)
            //{
            //    sortByWeight.AdjustWeights(Ted, movie);
            //}

            //for (int i = 0; i < movieList.Count; i+=2)
            //{
            //    sortByWeight.AdjustWeights(Claire, movieList[i]);
            //}

            //var tG = Ted.GetHeaviestWeight();
            //var tN = Ted.GetOrderedNamesByWeight();
            //var tS = Ted.GetOrderedWeights();

            //var cG = Claire.GetHeaviestWeight();
            //var cN = Claire.GetOrderedNamesByWeight();
            //var cS = Claire.GetOrderedWeights();

            //Console.WriteLine($@"Ted's favourite genre is {tG.Key} with a score of {tG.Value}");
            //Console.WriteLine($@"Claires's favourite genre is {cG.Key} with a score of {cG.Value}");

            //Console.WriteLine($@"Ted wants to rate {movieList[0].Name}, what does he give it out of 7?");
            //var TedRating = Convert.ToInt32(Console.ReadLine());
            //sortByWeight.AdjustWeights(Ted, movieList[0], TedRating);
            //foreach (var w in movieList[0].Weights)
            //{
            //    Console.WriteLine($@"{w.Key} : {w.Value}");
            //}

            //sortByWeight.getMovieByWeight(Ted);
            MovieSortByTag sortByTag = new MovieSortByTag();
            CsvLoader CsvLoader = new CsvLoader();


            //var movieList = sortByTag.moviesWithTags;

            //movieList.ForEach(m => m.PopulateRelated(movieList));

            //List<Dictionary<Movie, int>> l = new List<Dictionary<Movie, int>>();
            //movieList.ForEach(m => l.Add(m.GetRelatedMovies()));


            //movieList.ForEach(m => Console.WriteLine(m.Name));

            var ooo = CsvLoader.LoadMovieCSV();

            Viewer Ted = new Viewer("Ted");
            Viewer Claire = new Viewer("Claire");

            //ooo.ForEach(m => sortByTag.AdjustTagCount(Ted, m));
            foreach (var item in ooo)
            {
                if(item.ID % 2 == 0)
                {
                    sortByTag.AdjustTagCount(Ted, item);
                }
            }



            var movieList = sortByTag.getMovieByTag(Ted, ooo);

            //foreach (var movie in movieList)
            //{
            //    sortByTag.AdjustTagCount(Ted, movie);
            //}

            //sortByTag.AdjustTagCount(Ted, movieList[3]);
            //sortByTag.AdjustTagCount(Ted, movieList[3]);
            //sortByTag.AdjustTagCount(Ted, movieList[3]);
            //sortByTag.AdjustTagCount(Ted, movieList[3]);
            //sortByTag.AdjustTagCount(Ted, movieList[3]);
            //sortByTag.AdjustTagCount(Ted, movieList[3]);

            var wM = Ted.getWatchedMovies();
            

            //var result = sortByTag.getMovieByTag(Ted);

            //Console.WriteLine(result.Name);

            Console.WriteLine(Ted.Name);

            Console.ReadLine();

        }
    }
}



