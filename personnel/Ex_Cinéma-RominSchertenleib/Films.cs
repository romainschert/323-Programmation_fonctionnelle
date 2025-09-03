using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Cinéma_RominSchertenleib
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public double Rating { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }
        public string[] LanguageOptions { get; set; }

        public string[] StreamingPlatforms { get; set; }

    }
}
