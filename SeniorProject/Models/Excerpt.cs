using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Models
{
    public class Excerpt
    {
        public int ExcerptId { get; set; }      
        public string ExcerptTitle { get; set; }
        public string Composer { get; set; }
        public int YearPublished { get; set; }
        public int Difficulty { get; set; }
        public string StoreLink { get; set; }
    }

    public static class ExcerptCollection
    {
        private static Dictionary<string, List<Excerpt>> excerpts;
        
        static ExcerptCollection()
        {
            excerpts = new Dictionary<string, List<Excerpt>>
            {
                {
                    "Flute", new List<Excerpt>
                    {
                        new Excerpt //could make constructor in Excerpt to save space
                        {
                            ExcerptTitle = "Syrinx",
                            Composer = "Claude Debussy",
                            YearPublished = 1913,
                            Difficulty = 5, //maybe 6
                            StoreLink = "https://www.jwpepper.com/Syrinx/10274794.item#.YkYr5OfMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Duo",
                            Composer = "Aaron Copland",
                            YearPublished = 1971,
                            Difficulty = 4, //find difficulty
                            StoreLink = "yahoo" //find website
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata for Flute and Piano",
                            Composer = "Francis Poulenc",
                            YearPublished = 1957,
                            Difficulty = 3, //find difficulty
                            StoreLink = "duckduckgo" //find website
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata in B Minor",
                            Composer = "J.S. Bach",
                            YearPublished = 1762,
                            Difficulty = 3, //find difficulty
                            StoreLink = "duckduckgo" //find website
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Flute Concerto No. 2 in D Major",
                            Composer = "Wolfgang Mozart",
                            YearPublished = 1778,
                            Difficulty = 3, //find difficulty
                            StoreLink = "duckduckgo" //find website
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Le Merle Noir",
                            Composer = "Olivier Messiaen",
                            YearPublished = 1952,
                            Difficulty = 6, //find difficulty
                            StoreLink = "duckduckgo" //find website
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Chant de Linos",
                            Composer = "Andre Jolivet",
                            YearPublished = 1944,
                            Difficulty = 6, //find difficulty
                            StoreLink = "duckduckgo" //find website
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Andante Pastoral and Scherzettino",
                            Composer = "Paul Taffanel",
                            YearPublished = 1907,
                            Difficulty = 3, //find difficulty
                            StoreLink = "duckduckgo" //find website
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata for Flute and Piano",
                            Composer = "Paul Hindemith",
                            YearPublished = 1937,
                            Difficulty = 3, //find difficulty
                            StoreLink = "duckduckgo" //find website
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata Appassionata",
                            Composer = "Sigfrid Karg-Elert",
                            YearPublished = 1921,
                            Difficulty = 3, //find difficulty
                            StoreLink = "duckduckgo" //find website
                        }
                    }
                }
            };
        }

        public static List<Excerpt> getExcerpts(string instrument, string ordering)
        {
            List<Excerpt> musicList;
            excerpts.TryGetValue(instrument, out musicList);
            if (ordering == null)
            {                
                return musicList;
            }
            //add switch statement for ordering, then sort list of excerpts by that ordering
            return musicList;
        }
    }
}
