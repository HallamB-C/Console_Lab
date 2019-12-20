using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ConsoleLab.MovieStuff
{
    class MovieSortByWeight
    {
        public Movie getMovieByWeight(Viewer viewer)
        {
            var orderedScores = from pair in viewer.Weights
                                orderby pair.Value descending
                                select pair.Key;
            List<Movie> orderedMovies = new List<Movie>();
            foreach (var key in orderedScores)
            {
                orderedMovies = moviesWithWeights.OrderByDescending(m => m.Weights[key]).ToList();
            }
            return orderedMovies[0];
        }
        public List<Movie> moviesWithWeights = new List<Movie>()
        {
            //new Movie("Blade Runner 2049",6,5,4,3,2,1,0),
            //new Movie("The Notebook",5,4,3,2,1,0,6),
            //new Movie("Blade Runner",4,3,2,1,0,6,5),
            //new Movie("Hot Fuzz",3,2,1,0,6,5,4),
            //new Movie("Star Wars",2,1,0,6,5,4,3),
            //new Movie("Looney Tunes",1,0,6,5,4,3,2),
            //new Movie("Duck Tales",0,6,5,4,3,2,1),
            //new Movie("King Kong",6,0,1,2,3,4,5),
            //new Movie("Bill and Ted's Excellent Adventure",4,3,5,2,6,1,0),
            //new Movie("The Last Jedi",4,5,3,6,2,0,1)
            new Movie("Blade Runner 2049",3,2,1,0,-1,-2,-3),
            new Movie("Blade Runner",2,1,0,-1,-2,-3,3),
            new Movie("The Notebook",1,0,-1,-2,-3,3,2),
            new Movie("Hot Fuzz",0,-1,-2,-3,3,2,1),
            new Movie("Star Wars",-1,-2,-3,3,2,1,0),
            new Movie("Looney Tunes",-2,-3,3,2,1,0,-1),
            new Movie("Duck Tales",-3,3,2,1,0,-1,-2),
            new Movie("King Kong",3,-3,-2,-1,0,1,2),
            new Movie("Bill and Ted's Excellent Adventure",1,0,2,-1,3,-2,-3),
            new Movie("The Last Jedi",1,2,0,3,-1,-3,-2)
        };
        public List<Movie> resultMoviesWithWeights = new List<Movie>()
        {
            new Movie("6543210",6,5,4,3,2,1,0),
            new Movie("5432106",5,4,3,2,1,0,6),
            new Movie("4321065",4,3,2,1,0,6,5),
            new Movie("3210654",3,2,1,0,6,5,4),
            new Movie("2106543",2,1,0,6,5,4,3),
            new Movie("1065432",1,0,6,5,4,3,2)
        };
        public void AdjustWeights (Viewer viewer, Movie movie, int weight = 4)
        {
            if (!viewer.getWatchedMovies().Contains(movie))
            {
                viewer.addWatchedMovie(movie);
            }
            var viewerWeights = viewer.Weights;
            var Weights = movie.Weights;
            weight = weight > 7 ? 7 :
                    weight < 1 ? 1 : weight;
            weight -= 4;
            weight = weight > 3 ? 3 :
                    weight < -3 ? -3: weight;

            if((viewerWeights["ActionScore"] + Weights["ActionScore"] + weight) < 30 && (viewerWeights["ActionScore"] + Weights["ActionScore"] + weight) > -30)
            {
                viewerWeights["ActionScore"] += Weights["ActionScore"] + weight;
            }
            else
            {
                viewerWeights["ActionScore"] = 30;
            }
            if ((viewerWeights["AdventureScore"] + Weights["AdventureScore"] + weight) < 30 && (viewerWeights["ActionScore"] + Weights["ActionScore"] + weight) > -30)
            {
                viewerWeights["AdventureScore"] += Weights["AdventureScore"] + weight;
            }
            else
            {
                viewerWeights["AdventureScore"] = 30;
            }
            if ((viewerWeights["FantasyScore"] + Weights["FantasyScore"] + weight) < 30 && (viewerWeights["ActionScore"] + Weights["ActionScore"] + weight) > -30)
            {
                viewerWeights["FantasyScore"] += Weights["FantasyScore"] + weight;
            }
            else
            {
                viewerWeights["FantasyScore"] = 30;
            }
            if ((viewerWeights["ScifiScore"] + Weights["ScifiScore"] + weight) < 30 && (viewerWeights["ActionScore"] + Weights["ActionScore"] + weight) > -30)
            {
                viewerWeights["ScifiScore"] += Weights["ScifiScore"] + weight;
            }
            else
            {
                viewerWeights["ScifiScore"] = 30;
            }
            if ((viewerWeights["HorrorScore"] + Weights["HorrorScore"] + weight) < 30 && (viewerWeights["ActionScore"] + Weights["ActionScore"] + weight) > -30)
            {
                viewerWeights["HorrorScore"] += Weights["HorrorScore"] + weight;
            }
            else
            {
                viewerWeights["HorrorScore"] = 30;
            }
            if ((viewerWeights["RomanceScore"] + Weights["RomanceScore"] + weight) < 30 && (viewerWeights["ActionScore"] + Weights["ActionScore"] + weight) > -30)
            {
                viewerWeights["RomanceScore"] += Weights["RomanceScore"] + weight;
            }
            else
            {
                viewerWeights["ComedyScore"] = 30;
            }
            if ((viewerWeights["ComedyScore"] + Weights["ComedyScore"] + weight) < 30 && (viewerWeights["ActionScore"] + Weights["ActionScore"] + weight) > -30)
            {
                viewerWeights["ComedyScore"] += Weights["ComedyScore"] + weight;
            }
            else
            {
                viewerWeights["ComedyScore"] = 30;
            }
        }


    }

}
