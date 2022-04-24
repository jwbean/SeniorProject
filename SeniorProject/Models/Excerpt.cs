﻿using System;
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
                /*This block contains all the excerpts
                 * for the alto sax players
                 */
                {
                    "Alto Sax", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata",
                            Composer = "Paul Creston",
                            YearPublished = 1945,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Sonata/1006121.item#.YmR568jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Dix Figures a Danser",
                            Composer = "Pierre Max Dubois",
                            YearPublished = 1962,
                            Difficulty = 1, //find difficulty
                            StoreLink = "https://www.amazon.com/Figures-Danser-Alto-Saxophone-Piano/dp/B002DBRFI4"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Meditation",
                            Composer = "Jules Massenet",
                            YearPublished = 1894,
                            Difficulty = 2, //or 3 since M?
                            StoreLink = "https://www.jwpepper.com/Meditation-from-the-Opera-Thais/10564248.item#.YmR7yMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Holly Roller",
                            Composer = "Libby Larsen",
                            YearPublished = 1998,
                            Difficulty = 6, 
                            StoreLink = "https://www.jwpepper.com/Holy-Roller-Alto-Sax-and-Piano/5752555.item#.YmR8fcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Ode to Lord Buckley",
                            Composer = "David Amram",
                            YearPublished = 1980,
                            Difficulty = 4, //find difficulty
                            StoreLink = "https://www.jwpepper.com/7896921.item#.YmXKT8jMKUl"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Scaramouche",
                            Composer = "Darius Milhaud",
                            YearPublished = 1937,
                            Difficulty = 4,
                            StoreLink = "https://www.jwpepper.com/Scaramouche/10430286.item#.YmXLjsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Concertino da Camera",
                            Composer = "Jacques Ibert",
                            YearPublished = 1935,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concertino-Da-Camera/4777694.item#.YmXMcMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Concerto for Alto Sax",
                            Composer = "David Maslanka",
                            YearPublished = 1999,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concerto-for-Alto-Sax-and-Wind-Ensemble/10346279.item#.YmXNW8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Light of Sothis",
                            Composer = "Amy Quate",
                            YearPublished = 1982,
                            Difficulty = 5, //check difficulty
                            StoreLink = "https://www.jwpepper.com/Light-of-Sothis-Alto-Sax-Piano/7895733.item#.YmXQBMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Parable XI",
                            Composer = "Vincent Persichetti",
                            YearPublished = 1972,
                            Difficulty = 6, //check difficulty
                            StoreLink = "https://www.jwpepper.com/Parable-for-Solo-Alto-Saxophone/4610572.item#.YmXOxcjMKUk"
                        }
                    }
                },
                /*This block contains all the excerpts
                 * for the clarinet players
                 */
                {
                    "Clarinet", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Premiere Rhapsodie",
                            Composer = "Claude Debussy",
                            YearPublished = 1910,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Premiere-Rhapsodie/10799668.item#.YmHENsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Concerto for Clarinet",
                            Composer = "Aaron Copland",
                            YearPublished = 1949,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concerto-for-Clarinet/2023935.item#.YmHEm8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata for Clarinet",
                            Composer = "Leonard Bernstein",
                            YearPublished = 1942,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Sonata-for-Clarinet-and-Piano/10162812.item#.YmHuF8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Clarinet Sonata",
                            Composer = "Francis Poulenc",
                            YearPublished = 1962,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Sonata-for-Clarinet-and-Piano/10024397.item#.YmHvJcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Clarinet Concerto No. 2",
                            Composer = "Carl Maria von Weber",
                            YearPublished = 1811,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concerto-No.-2-in-E-flat%2C-Op.-74/4600383.item#.YmHvpMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata No. 2",
                            Composer = "Johannes Brahms",
                            YearPublished = 1894,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Sonata-No.-2-in-Eb-Op.-120-2/5983813.item#.YmHv28jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Fantasy Pieces",
                            Composer = "Robert Schumann",
                            YearPublished = 1849,
                            Difficulty = 3, //M
                            StoreLink = "https://www.jwpepper.com/Fantasy-Piece/4557260.item#.YmHxUcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Introduction, Theme, and Variations",
                            Composer = "Gioacchino Rossini",
                            YearPublished = 1819,
                            Difficulty = 2, //ME
                            StoreLink = "https://www.jwpepper.com/Introduction%2C-Theme-and-Variations/10799910.item#.YmHyS8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Three Pieces for Solo Clarinet",
                            Composer = "Igor Stravinsky",
                            YearPublished = 1919,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Three-Pieces-Clarinet-Solo/5043229.item#.YmHy3MjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Grand Duo Concertante",
                            Composer = "Carl Maria von Weber",
                            YearPublished = 1816,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Grand-Duo-Concertante%2C-for-Clarinet-and-Piano%2C-Op.-48/4894754.item#.YmHzdcjMKUk"
                        }
                    }
                },
                /*This block contains all the excerpts
                 * for the flute players
                 */
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
                /*This block contains all the excerpts
                 * for the french horn players
                 */
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
                /*This block contains all the excerpts
                 * for the oboe players
                 */
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
            switch (ordering)
            {
                case null:
                case "Title":
                    //sort by title
                    musicList = musicList.OrderBy(x => x.ExcerptTitle).ToList();
                    break;
                case "Composer":
                    //sort by composer
                    musicList = musicList.OrderBy(x => x.Composer).ToList();
                    break;
                case "Year Published":
                    //sort by year published
                    musicList = musicList.OrderBy(x => x.YearPublished).ToList();
                    break;
                case "Difficulty":
                    //sort by difficulty
                    musicList = musicList.OrderBy(x => x.Difficulty).ToList();
                    break;
                default:
                    //sort by title
                    musicList = musicList.OrderBy(x => x.ExcerptTitle).ToList();
                    break;
            }
            return musicList;
        }
    }
}
