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
                            ExcerptTitle = "Concerto",
                            Composer = "Bach",
                            YearPublished = 2000,
                            Difficulty = 5,
                            StoreLink = "google"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Concerto",
                            Composer = "Bach",
                            YearPublished = 2000,
                            Difficulty = 5,
                            StoreLink = "google"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Concerto",
                            Composer = "Bach",
                            YearPublished = 2000,
                            Difficulty = 5,
                            StoreLink = "google"
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
