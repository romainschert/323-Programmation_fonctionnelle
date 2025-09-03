using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_Cinema2_RomainSchertenleib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> frenchMovies = new List<Movie>()
            {
            new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
            new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 8.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
            new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 8.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
            new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
            new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
            new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
            new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 8.4, Year = 2003, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} }
            };

            // exercie 1 Filtrer les films qui ne sont pas du genre "Comédie" or "Drame".

            List<Movie> Not_ComedieDrame = frenchMovies.Where(x => x.Genre != ("Drame") && x.Genre !=("Comédie") ).ToList();

            Console.Write("Film qui ne sont pas du genre Drame ou Comédie: ==> ");

            foreach(Movie movie in Not_ComedieDrame)
            {
                Console.Write("  " + movie.Title +" "+ movie.Genre + ",");
            }

            
            ////////////////////////////////////

            // exercie 2 Identifier les films dont le rating est superieur a 8.5

            List<Movie> Rating_under7 = frenchMovies.Where(x => x.Rating > 8.5).ToList();

            Console.Write("\n\nFilm dont le rating est plus grand que 8.5: ==> ");

            foreach (Movie movie in Rating_under7)
            {
                Console.Write("  " + movie.Title + ",");
            }

            ////////////////////////////////////

            // exercice 3 Afficher les films réalisés avant 2000.

            List<Movie> film_in2000 = frenchMovies.Where(x => x.Year < 2000).ToList();

            Console.Write("\n\nFilm réalisés avant 2000 : ==> ");

            foreach (Movie movie in film_in2000)
            {
                Console.Write("  " + movie.Title + " " + movie.Year  + ",");
            }

            ////////////////////////////////////

            // exercice 4 Trouver les films qui n'ont pas de doublage en français.

            List<Movie> No_frenchlanguageOptions = frenchMovies.Where(x => !x.LanguageOptions.Contains("Français")).ToList();

            Console.Write("\n\nFilm réalisés avant 2000 : ==> ");

            foreach (Movie movie in No_frenchlanguageOptions)
            {
                Console.Write("  " + movie.Title + ",");
            }

            ////////////////////////////////////

            // exercice 5 Identifier les films non présents sur netflix.

            List<Movie> No_netflixStreamingPlatforms = frenchMovies.Where(x => !x.StreamingPlatforms.Contains("Netflix")).ToList();

            Console.Write("\n\nFilm  non présents sur netflix: ==> ");

            foreach (Movie movie in No_netflixStreamingPlatforms)
            {
                Console.Write("  " + movie.Title + ",");
            }

            ////////////////////////////////////
            
            // exercie 6 cumul

            List<Movie> cumul = frenchMovies.Where(x => x.Genre != ("Drame") && x.Genre != ("Comédie") 
            && x.Rating > 8.5 && x.Year < 2000 && !x.LanguageOptions.Contains("Français") && !x.StreamingPlatforms.Contains("Netflix") ).ToList();

            Console.Write("\n\ncumul des filtres: ==> ");

            foreach (Movie movie in cumul)
            {
                Console.Write("  " + movie.Title + ",");
            }

        }

    }
}
