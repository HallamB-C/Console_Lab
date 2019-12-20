using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleLab.MovieStuff
{
    public class Viewer
    {
        public readonly string Name;
        public Dictionary<string, int> Weights = new Dictionary<string, int>()
        {
            {"ActionScore", 0},
            {"AdventureScore", 0},
            {"FantasyScore", 0},
            {"ScifiScore", 0},
            {"HorrorScore", 0},
            {"RomanceScore", 0},
            {"ComedyScore", 0},
        };
        public Dictionary<string, int> Tags = new Dictionary<string, int>();
        private List<Movie> WatchedMovies = new List<Movie>();
        public Viewer(string name)
        {
            Name = name;
        }
        // Weight functions
        public KeyValuePair<string, int> GetHeaviestWeight()
        {
            var orderedScores = from pair in Weights
                                orderby pair.Value descending
                                select pair;

            return orderedScores.FirstOrDefault();
        }
        public List<string> GetOrderedNamesByWeight()
        {
            var orderedScores = from pair in Weights
                                orderby pair.Value descending
                                select pair.Key;
            return orderedScores.ToList<string>();
        }
        public List<int> GetOrderedWeights()
        {
            var orderedScores = from pair in Weights
                                orderby pair.Value descending
                                select pair.Value;
            return orderedScores.ToList<int>();
        }
        
        // Tag functions
        public void addWatchedMovie(Movie movie)
        {
            WatchedMovies.Add(movie);

        }
        public List<Movie> getWatchedMovies()
        {
            return WatchedMovies;
        }
    }
}
