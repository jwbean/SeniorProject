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
                },
                {
                    "French Horn", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Horn Sonata in F Major",
                            Composer = "Ludwig van Beethoven",
                            YearPublished = 1800,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Sonata-in-F-Major%2C-Op.-17/5447107.item#.Yl4j0MjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Swings and Roundabouts",
                            Composer = "Anthony Randall",
                            YearPublished = 1994,
                            Difficulty = 1,
                            StoreLink = "https://www.sheetmusicplus.com/title/swings-and-roundabouts-sheet-music/21073159"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Romance in F",
                            Composer = "Camille Saint-Saens",
                            YearPublished = 1874,
                            Difficulty = 4, //M
                            StoreLink = "https://www.jwpepper.com/Romance%2C-Op.-36/4844627.item#.Yl4lGMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Horn Concerto No. 1",
                            Composer = "Richard Strauss",
                            YearPublished = 1882,
                            Difficulty = 4, //M
                            StoreLink = "https://www.jwpepper.com/Horn-Concerto-No.-1/11200737.item#.Yl4llsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Horn Concerto, Op.8",
                            Composer = "Franz Strauss",
                            YearPublished = 1865,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Concerto%2C-Op.-8/995118.item#.Yl4l-cjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Morceau de Concert",
                            Composer = "Camille Saint-Saens",
                            YearPublished = 1887,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Morceau-de-Concert/1003219.item#.Yl4mVMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Berceuse Op. 19",
                            Composer = "Jean-Michel Damase",
                            YearPublished = 1981, //find year
                            Difficulty = 3,
                            StoreLink = "https://shop.trinitycollege.com/shop/prod/Damase-Jean-Michel-Berceuse-Op-19/621602"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Moody Horn",
                            Composer = "Mabel Hardy",
                            YearPublished = 1974,
                            Difficulty = 4,
                            StoreLink = "https://www.boosey.com/shop/prod/Hardy-Mabel-Moody-Horn/2083691"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Horn Concerto No. 3",
                            Composer = "Wolfgang Mozart",
                            YearPublished = 1787,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Concerto-No.-3%2C-K.-447/1005842.item#.Yl4qbcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Prelude",
                            Composer = "Ronald Hanmer",
                            YearPublished = 1975,
                            Difficulty = 2,
                            StoreLink = "https://www.sheetmusicplus.com/title/suite-for-horn-sheet-music/21022111"
                        }
                    }
                },
                {
                    "Oboe", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Two Fantasy Pieces",
                            Composer = "Carl Nielsen",
                            YearPublished = 1889,
                            Difficulty = 5, //A
                            StoreLink = "https://www.jwpepper.com/Fantasy-Pieces%2C-Op.-2/10537565.item#.Yl4tvsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sequenza VIIa",
                            Composer = "Luciano Berio",
                            YearPublished = 1969,
                            Difficulty = 6,
                            StoreLink = "https://www.boosey.com/shop/prod/Berio-Luciano-Sequenza-VIIa/2108286"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Six Metamorphoses after Ovid",
                            Composer = "Benjamin Britten",
                            YearPublished = 1951,
                            Difficulty = 5,
                            StoreLink = "https://www.sheetmusicplus.com/title/six-metamorphoses-after-ovid-for-solo-oboe-op-49-sheet-music/4161710"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Five Pieces",
                            Composer = "Antal Dorati",
                            YearPublished = 1980,
                            Difficulty = 5,
                            StoreLink = "https://www.mmimports.com/product/antal-dorati-five-pieces-for-oboe/"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Piece in G Minor",
                            Composer = "Gabriel Pierne",
                            YearPublished = 1883,
                            Difficulty = 2, 
                            StoreLink = "https://www.sheetmusicplus.com/title/piece-in-g-minor-sheet-music/3806551"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Oboe Sonata No. 2 in B-flat",
                            Composer = "G.F. Handel",
                            YearPublished = 1710,
                            Difficulty = 4,
                            StoreLink = "https://www.sheetmusicplus.com/title/handel-oboe-sonata-in-b-flat-hwv-357-for-oboe-continuo-and-harpsichord-or-piano-digital-sheet-music/20654291"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Pastorale",
                            Composer = "Michael Arne",
                            YearPublished = 1745,
                            Difficulty = 4,
                            StoreLink = "https://www.jwpepper.com/Pastorale-Oboe-Solo/5188065.item#.Yl40W8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sarabande et Allegro",
                            Composer = "Gabriel Grovlez",
                            YearPublished = 1929,
                            Difficulty = 6, //A
                            StoreLink = "https://www.halleonard.com/product/48181526/gabriel-grovlez-sarabande-et-allegro-pour-hautbois-et-piano"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata in G Minor",
                            Composer = "J.S. Bach",
                            YearPublished = 1736,
                            Difficulty = 3,
                            StoreLink = "https://www.sheetmusicplus.com/title/j-s-bach-sonata-in-g-minor-bwv-1020-arranged-for-oboe-and-piano-or-harp-digital-sheet-music/20271826"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Oboe Sonata",
                            Composer = "Camille Saint-Saens",
                            YearPublished = 1921,
                            Difficulty = 3,
                            StoreLink = "https://www.sheetmusicplus.com/title/saint-sans-oboe-sonata-op-166-for-oboe-and-piano-digital-sheet-music/22206702"
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
