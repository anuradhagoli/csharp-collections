using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class MovieCollection
    {
        public void ManageMovies()
        {
            // Creating a Dictionary for the movie collection
            Dictionary<string, int> movies = new Dictionary<string, int>();

            // Adding key-value pairs for MovieName-ReleaseYear
            movies["Inception"] = 2010;
            // TODO: Add any other movies to the movie collection along with their release year
            // Examples: (The Matrix, 1999), (Interstellar, 2014)
            movies["The Matrix"] = 1999;
            movies["Interstellar"] = 2014;
            // Display the release year of "Inception"
            Console.WriteLine(movies["Inception"]);
        }
    }
}
