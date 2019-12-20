using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleLab.MovieStuff
{
    public class Movie
    {
        public readonly int ID;
        //private int idCount = 0;
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
        public List<string> Tags = new List<string>();
        public Movie(string name, int ActionScore = 0, int AdventureScore = 0, int FantasyScore = 0, int ScifiScore = 0, int HorrorScore = 0, int RomanceScore = 0, int ComedyScore = 0)
        {
            this.Name = name;
            Weights["ActionScore"] = ActionScore;
            Weights["AdventureScore"] = AdventureScore;
            Weights["FantasyScore"] = FantasyScore;
            Weights["ScifiScore"] = ScifiScore;
            Weights["HorrorScore"] = HorrorScore;
            Weights["RomanceScore"] = RomanceScore;
            Weights["ComedyScore"] = ComedyScore;
        }
        public Movie(int id, string name, List<string> tags)
        {
            this.ID = id;
            this.Name = name;

            foreach (var tag in tags)
            {
                Tags.Add(tag);
            }
        }
        public void AddTag(string tagName)
        {
            Tags.Add(tagName);
        }

        private Dictionary<Movie, int> RelatedMovies = new Dictionary<Movie, int>();

        public Dictionary<Movie, int> GetRelatedMovies()
        {
            return RelatedMovies;
        }
        public void PopulateRelated(IEnumerable<Movie> movieList)
        {
            Dictionary<Movie, int> tempDict = new Dictionary<Movie, int>();
            foreach (var movie in movieList)
            {
                if(movie == this)
                {
                    continue;
                }
                var intersect = Tags.Intersect(movie.Tags).Count();
                tempDict.Add(movie, intersect);
            }
            Dictionary<Movie, int> result = new Dictionary<Movie, int>();
            var Related = from pair in RelatedMovies
                          orderby pair.Value descending
                          select pair;
            foreach (var item in Related)
            {
                result.Add(item.Key, item.Value);
            }
            RelatedMovies = result;
        }
    }

}