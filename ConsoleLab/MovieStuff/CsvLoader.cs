using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace ConsoleLab.MovieStuff
{
    class CsvLoader
    {
        public List<Movie> LoadMovieCSV()
        {
            var fileToUse = $@"C:\Users\bio356\source\repos\ConsoleLab\ConsoleLab\MovieStuff\movies.csv";
            var output = File.ReadAllLines(fileToUse)
                             .Skip(1)
                             .Select(r => RowToMovie(r))
                             .ToList();
            return output;
        }
        public static Movie RowToMovie(string csvLine)
        {
            string[] values = csvLine.Split(',');
            if(values.Length > 4)
            {
                throw new Exception();
            }
            var mID = Convert.ToInt32(values[0]);
            string mName = values[1];
            mName = values[1].Replace('@', ',');
            var mYear = values[2];
            var mTags = values[3];
            List<string> tagsToAdd = mTags.Split('|').ToList();
            Movie movieOutput = new Movie(mID, mName, tagsToAdd);
            return movieOutput;
        }
    }
}
