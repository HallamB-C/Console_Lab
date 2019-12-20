using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLab.MovieStuff
{
    class MovieSortByTag
    {
        public Movie getMovieByTag(Viewer viewer, List<Movie> movieList)
        {
            var orderedScores = from pair in viewer.Tags
                                orderby pair.Value descending
                                select pair.Key;
            List<Movie> orderedMovies = new List<Movie>();
            orderedMovies.AddRange(movieList);
            Movie mostMatches = orderedMovies[0];
            foreach (Movie movie in orderedMovies)
            {
                if (viewer.getWatchedMovies().Contains(movie))
                {
                    continue;
                }
                var movieScoreIntersect = movie.Tags.Intersect(orderedScores).Count();
                var movieExtra = movie.Tags.Count() - movieScoreIntersect;
                var mostMatchesExtra = mostMatches.Tags.Count() - mostMatches.Tags.Intersect(orderedScores).Count();

                if (movieScoreIntersect == orderedScores.Count())
                {
                    if (movieExtra > mostMatchesExtra)
                    {
                        continue;
                    }
                    mostMatches = movie;
                }

            }
            return mostMatches;
        }
        //public List<Movie> moviesWithTags = new List<Movie>()
        //{
        //    new Movie("Blade Runner 2049", new List<string>(){"Action","Adventure","Scifi","Horror"}),
        //    new Movie("Blade Runner", new List<string>(){"Action","Adventure","Fantasy","Scifi","Romance"}),
        //    new Movie("The Notebook", new List<string>(){"Romance"}),
        //    new Movie("Hot Fuzz", new List<string>(){"Action","Comedy" }),
        //    new Movie("Star Wars", new List<string>(){"Action","Adventure","Scifi"}),
        //    new Movie("Looney Tunes", new List<string>(){"Comedy"}),
        //    new Movie("Duck Tales", new List<string>(){"Horror"}),
        //    new Movie("King Kong", new List<string>(){"Action","Adventure","Scifi","Horror"}),
        //    new Movie("Bill and Ted's Excellent Adventure", new List<string>(){"Adventure","Scifi","Comedy"}),
        //    new Movie("The Last Jedi", new List<string>(){"Action","Adventure","Scifi"})
        //};
        //public List<Movie> resultMoviesWithTags = new List<Movie>()
        //{
        //    new Movie("Scifi Result", new List<string>(){"Scifi"}),
        //    new Movie("Action Result", new List<string>(){"Action"}),
        //    new Movie("Horror Result", new List<string>(){"Horror"}),
        //    new Movie("Adventure Then Comedy Result",  new List<string>(){"Adventure","Comedy"}),
        //    new Movie("Romance", new List<string>(){"Romance"}),
        //    new Movie("Comendy Then Action Result", new List<string>(){"Action","Comedy"})
        //};
        public void AdjustTagCount(Viewer viewer, Movie movie)
        {
            viewer.addWatchedMovie(movie);
            List<string> vTags = new List<string>();
            List<string> mTags = new List<string>();
            vTags.AddRange(viewer.Tags.Keys);
            mTags.AddRange(movie.Tags);
            foreach (var item in mTags)
            {
                if (vTags.Contains(item))
                {
                    viewer.Tags[item] += 1;
                }
                else
                {
                    viewer.Tags.Add(item, 1);
                }
            }
            foreach (var tag in vTags)
            {
                if (!mTags.Contains(tag))
                {
                    if (viewer.Tags[tag] - 1 > 0)
                    {
                        viewer.Tags[tag] -= 1;
                    }
                    else if (viewer.Tags[tag] - 1 < 0)
                    {
                        viewer.Tags.Remove(tag);
                    }
                }
            }
        }

    }
    
}

