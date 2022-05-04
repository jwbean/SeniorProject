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
                /*This block contains all the excerpts
                 * for the alto sax players
                 */
                {
                    "Alto Sax", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata",
                            Composer = "Creston, Paul",
                            YearPublished = 1945,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Sonata/1006121.item#.YmR568jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Dix Figures a Danser",
                            Composer = "Dubois, Pierre Max",
                            YearPublished = 1962,
                            Difficulty = 1, //find difficulty
                            StoreLink = "https://www.amazon.com/Figures-Danser-Alto-Saxophone-Piano/dp/B002DBRFI4"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Meditation",
                            Composer = "Massenet, Jules",
                            YearPublished = 1894,
                            Difficulty = 2, //or 3 since M?
                            StoreLink = "https://www.jwpepper.com/Meditation-from-the-Opera-Thais/10564248.item#.YmR7yMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Holly Roller",
                            Composer = "Larsen, Libby",
                            YearPublished = 1998,
                            Difficulty = 6, 
                            StoreLink = "https://www.jwpepper.com/Holy-Roller-Alto-Sax-and-Piano/5752555.item#.YmR8fcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Ode to Lord Buckley",
                            Composer = "Amram, David",
                            YearPublished = 1980,
                            Difficulty = 4, //find difficulty
                            StoreLink = "https://www.jwpepper.com/7896921.item#.YmXKT8jMKUl"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Scaramouche",
                            Composer = "Milhaud, Darius",
                            YearPublished = 1937,
                            Difficulty = 4,
                            StoreLink = "https://www.jwpepper.com/Scaramouche/10430286.item#.YmXLjsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Concertino da Camera",
                            Composer = "Ibert, Jacques",
                            YearPublished = 1935,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concertino-Da-Camera/4777694.item#.YmXMcMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Concerto for Alto Sax",
                            Composer = "Maslanka, David",
                            YearPublished = 1999,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concerto-for-Alto-Sax-and-Wind-Ensemble/10346279.item#.YmXNW8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Light of Sothis",
                            Composer = "Quate, Amy",
                            YearPublished = 1982,
                            Difficulty = 5, //check difficulty
                            StoreLink = "https://www.jwpepper.com/Light-of-Sothis-Alto-Sax-Piano/7895733.item#.YmXQBMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Parable XI",
                            Composer = "Persichetti, Vincent",
                            YearPublished = 1972,
                            Difficulty = 6, //check difficulty
                            StoreLink = "https://www.jwpepper.com/Parable-for-Solo-Alto-Saxophone/4610572.item#.YmXOxcjMKUk"
                        }
                    }
                },
                /*This block contains all the excerpts
                 * for the bassoon players
                 */
                {
                    "Bassoon", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Elegy for Innocence",
                            Composer = "Scott, Jeff",
                            YearPublished = 2008,
                            Difficulty = 6, //grade 8 on 8 scale
                            StoreLink = "https://www.trevcomusic.com/products/tco-1103-scott-jeff-elegy-for-innocence-bsn-pn"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "The Sorcerer's Apprentice",
                            Composer = "Dukas, Paul",
                            YearPublished = 1897,
                            Difficulty = 2, //one arrangement was ME
                            StoreLink = "https://www.jwpepper.com/The-Sorcerer%27s-Apprentice/11194249E.item#.YmoBGcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Song Without Words",
                            Composer = "Weissenborn, Ernest",
                            YearPublished = 1989,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Song-Without-Words/995506.item#.YmoC8MjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Happy Farmer",
                            Composer = "Schumann, Robert",
                            YearPublished = 1878,
                            Difficulty = 1, //VE
                            StoreLink = "https://www.jwpepper.com/Happy-Farmer/4586962.item#.YmrvVsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Minuetto from Don Giovanni",
                            Composer = "Mozart, W.A.",
                            YearPublished = 1787,
                            Difficulty = 1,
                            StoreLink = "https://www.jwpepper.com/Minuetto/4846978.item#.YmrwC8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Piece for Bassoon",
                            Composer = "Faure, Gabriel",
                            YearPublished = 1902,
                            Difficulty = 4, //maybe 5?
                            StoreLink = "https://www.jwpepper.com/Piece-for-Bassoon-and-Piano/10674928.item#.YmrxGMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Fantasy for Bassoon",
                            Composer = "Arnold, Malcolm",
                            YearPublished = 1966,
                            Difficulty = 6,
                            StoreLink = "https://www.boosey.com/shop/prod/Arnold-Malcolm-Fantasy-for-Bassoon/2016206"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Reverie",
                            Composer = "Jancourt, Eugene",
                            YearPublished = 1882,
                            Difficulty = 3, //M
                            StoreLink = "https://www.jwpepper.com/Reverie-Op.-61-Bassoon-Solo/5005558.item#.Ymr0HcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Minuet (Grace For A Fresh Egg)",
                            Composer = "Howells, Herbert",
                            YearPublished = 1945,
                            Difficulty = 3, //Intermediate
                            StoreLink = "https://www.trevcomusic.com/products/nov-12056303-howells-minuet-grace-for-a-fresh-egg-bsn-pn"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Minuet in G",
                            Composer = "Bach, J.S.",
                            YearPublished = 1720,
                            Difficulty = 2,
                            StoreLink = "https://www.jwpepper.com/Menuet-in-G-from-Anna-Bassoon-Solo/4608980.item#.Ymr1esjMKUk"
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
                            Composer = "Debussy, Claude",
                            YearPublished = 1910,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Premiere-Rhapsodie/10799668.item#.YmHENsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Concerto for Clarinet",
                            Composer = "Copland, Aaron",
                            YearPublished = 1949,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concerto-for-Clarinet/2023935.item#.YmHEm8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata for Clarinet",
                            Composer = "Bernstein, Leonard",
                            YearPublished = 1942,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Sonata-for-Clarinet-and-Piano/10162812.item#.YmHuF8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Clarinet Sonata",
                            Composer = "Poulenc, Francis",
                            YearPublished = 1962,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Sonata-for-Clarinet-and-Piano/10024397.item#.YmHvJcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Clarinet Concerto No. 2",
                            Composer = "Weber, Carl Maria von",
                            YearPublished = 1811,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concerto-No.-2-in-E-flat%2C-Op.-74/4600383.item#.YmHvpMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata No. 2",
                            Composer = "Brahms, Johannes",
                            YearPublished = 1894,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Sonata-No.-2-in-Eb-Op.-120-2/5983813.item#.YmHv28jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Fantasy Pieces",
                            Composer = "Schumann, Robert",
                            YearPublished = 1849,
                            Difficulty = 3, //M
                            StoreLink = "https://www.jwpepper.com/Fantasy-Piece/4557260.item#.YmHxUcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Introduction, Theme, and Variations",
                            Composer = "Rossini, Gioacchino",
                            YearPublished = 1819,
                            Difficulty = 2, //ME
                            StoreLink = "https://www.jwpepper.com/Introduction%2C-Theme-and-Variations/10799910.item#.YmHyS8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Three Pieces for Solo Clarinet",
                            Composer = "Stravinsky, Igor",
                            YearPublished = 1919,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Three-Pieces-Clarinet-Solo/5043229.item#.YmHy3MjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Grand Duo Concertante",
                            Composer = "Weber, Carl Maria von",
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
                            Composer = "Debussy, Claude",
                            YearPublished = 1913,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Syrinx/998351.item#.YnAZIMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Duo",
                            Composer = "Copland, Aaron",
                            YearPublished = 1971,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Duo-for-Flute-and-Piano/4607800.item#.YnAZVsjMKUk" 
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata for Flute and Piano",
                            Composer = "Poulenc, Francis",
                            YearPublished = 1957,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Sonata-for-Flute-and-Piano/4864740.item#.YnAZfsjMKUk" 
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata in B Minor",
                            Composer = "Bach, J.S.",
                            YearPublished = 1762,
                            Difficulty = 3, //M
                            StoreLink = "https://www.jwpepper.com/Sonata-in-B-Minor-BWV1030-Flute-Sol/5421292.item#.YnAZrMjMKUk" 
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Flute Concerto No. 2 in D Major",
                            Composer = "Mozart, W.A.",
                            YearPublished = 1778,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Concerto-No.-2-in-D-Major%2C-K.-314/7263072.item#.YnAZ6sjMKUk" 
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Le Merle Noir",
                            Composer = "Messiaen, Olivier",
                            YearPublished = 1952,
                            Difficulty = 4, //find difficulty
                            StoreLink = "https://www.jwpepper.com/Le-Merle-Noir%2C-for-Flute-and-Piano/4777108.item#.YnAaLcjMKUk" 
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Chant de Linos",
                            Composer = "Jolivet, Andre",
                            YearPublished = 1944,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Chant-de-Linos-Flute-Solo/4777090.item#.YnAatcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Andante Pastoral and Scherzettino",
                            Composer = "Taffanel, Paul",
                            YearPublished = 1907,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Andante-Pastoral-et-Scherzettino/10302444.item#.YnAa5cjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata for Flute and Piano",
                            Composer = "Hindemith, Paul",
                            YearPublished = 1937,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Sonata-for-Flute-and-Piano/997684.item#.YnAbFMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata Appassionata",
                            Composer = "Karg-Elert, Sigfrid",
                            YearPublished = 1921,
                            Difficulty = 5,
                            StoreLink = "https://www.jwpepper.com/sheet-music/7169246.item#.YnAbSsjMKUk"
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
                            Composer = "Beethoven, Ludwig van",
                            YearPublished = 1800,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Sonata-in-F-Major%2C-Op.-17/5447107.item#.Yl4j0MjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Swings and Roundabouts",
                            Composer = "Randall, Anthony",
                            YearPublished = 1994,
                            Difficulty = 1,
                            StoreLink = "https://www.sheetmusicplus.com/title/swings-and-roundabouts-sheet-music/21073159"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Romance in F",
                            Composer = "Saint-Saens, Camille",
                            YearPublished = 1874,
                            Difficulty = 4, //M
                            StoreLink = "https://www.jwpepper.com/Romance%2C-Op.-36/4844627.item#.Yl4lGMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Horn Concerto No. 1",
                            Composer = "Strauss, Richard",
                            YearPublished = 1882,
                            Difficulty = 4, //M
                            StoreLink = "https://www.jwpepper.com/Horn-Concerto-No.-1/11200737.item#.Yl4llsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Horn Concerto, Op.8",
                            Composer = "Strauss, Franz",
                            YearPublished = 1865,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Concerto%2C-Op.-8/995118.item#.Yl4l-cjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Morceau de Concert",
                            Composer = "Saint-Saens, Camille",
                            YearPublished = 1887,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Morceau-de-Concert/1003219.item#.Yl4mVMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Berceuse Op. 19",
                            Composer = "Damase, Jean-Michel",
                            YearPublished = 1981, //find year
                            Difficulty = 3,
                            StoreLink = "https://shop.trinitycollege.com/shop/prod/Damase-Jean-Michel-Berceuse-Op-19/621602"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Moody Horn",
                            Composer = "Hardy, Mabel",
                            YearPublished = 1974,
                            Difficulty = 4,
                            StoreLink = "https://www.boosey.com/shop/prod/Hardy-Mabel-Moody-Horn/2083691"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Horn Concerto No. 3",
                            Composer = "Mozart, W.A.",
                            YearPublished = 1787,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Concerto-No.-3%2C-K.-447/1005842.item#.Yl4qbcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Prelude",
                            Composer = "Hanmer, Ronald",
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
                            Composer = "Nielsen, Carl",
                            YearPublished = 1889,
                            Difficulty = 5, //A
                            StoreLink = "https://www.jwpepper.com/Fantasy-Pieces%2C-Op.-2/10537565.item#.Yl4tvsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sequenza VIIa",
                            Composer = "Berio, Luciano",
                            YearPublished = 1969,
                            Difficulty = 6,
                            StoreLink = "https://www.boosey.com/shop/prod/Berio-Luciano-Sequenza-VIIa/2108286"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Six Metamorphoses after Ovid",
                            Composer = "Britten, Benjamin",
                            YearPublished = 1951,
                            Difficulty = 5,
                            StoreLink = "https://www.sheetmusicplus.com/title/six-metamorphoses-after-ovid-for-solo-oboe-op-49-sheet-music/4161710"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Five Pieces",
                            Composer = "Dorati, Antal",
                            YearPublished = 1980,
                            Difficulty = 5,
                            StoreLink = "https://www.mmimports.com/product/antal-dorati-five-pieces-for-oboe/"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Piece in G Minor",
                            Composer = "Pierne, Gabriel",
                            YearPublished = 1883,
                            Difficulty = 2, 
                            StoreLink = "https://www.sheetmusicplus.com/title/piece-in-g-minor-sheet-music/3806551"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Oboe Sonata No. 2 in B-flat",
                            Composer = "Handel, G.F.",
                            YearPublished = 1710,
                            Difficulty = 4,
                            StoreLink = "https://www.sheetmusicplus.com/title/handel-oboe-sonata-in-b-flat-hwv-357-for-oboe-continuo-and-harpsichord-or-piano-digital-sheet-music/20654291"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Pastorale",
                            Composer = "Arne, Michael",
                            YearPublished = 1745,
                            Difficulty = 4,
                            StoreLink = "https://www.jwpepper.com/Pastorale-Oboe-Solo/5188065.item#.Yl40W8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sarabande et Allegro",
                            Composer = "Grovlez, Gabriel",
                            YearPublished = 1929,
                            Difficulty = 6, //A
                            StoreLink = "https://www.halleonard.com/product/48181526/gabriel-grovlez-sarabande-et-allegro-pour-hautbois-et-piano"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata in G Minor",
                            Composer = "Bach, J.S.",
                            YearPublished = 1736,
                            Difficulty = 3,
                            StoreLink = "https://www.sheetmusicplus.com/title/j-s-bach-sonata-in-g-minor-bwv-1020-arranged-for-oboe-and-piano-or-harp-digital-sheet-music/20271826"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Oboe Sonata",
                            Composer = "Saint-Saens, Camille",
                            YearPublished = 1921,
                            Difficulty = 3,
                            StoreLink = "https://www.sheetmusicplus.com/title/saint-sans-oboe-sonata-op-166-for-oboe-and-piano-digital-sheet-music/22206702"
                        }
                    }
                },
                /*This block contains all the excerpts
                 * for the tenor sax players
                 */
                {
                    "Tenor Sax", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Tre Pezzi",
                            Composer = "Scelsi, Giacinto",
                            YearPublished = 1956,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Tre+Pezzi+per+Saxophone/5569900.item#.YnAeI8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "The Upward Stream",
                            Composer = "Peck, Russell",
                            YearPublished = 2001,
                            Difficulty = 6, 
                            StoreLink = "https://www.jwpepper.com/Upward-Stream/10558659.item#.YnAfQMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Classical Concerto",
                            Composer = "Ewazen, Eric",
                            YearPublished = 1992,
                            Difficulty = 6,
                            StoreLink = "https://www.jwpepper.com/Classical-Concerto/10443956.item#.YnAf0cjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonatina",
                            Composer = "Schmitt, Jacob",
                            YearPublished = 1992,
                            Difficulty = 5, //find difficulty
                            StoreLink = "https://www.jwpepper.com/Classical-Concerto/10443956.item#.YnAf0cjMKUk" //find website
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata in G Minor",
                            Composer = "Vivaldi, Antonio",
                            YearPublished = 1709,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Sonata-in-G-Minor/4864971.item#.YnAhScjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Fantaise",
                            Composer = "Bedard, Denis",
                            YearPublished = 1995,
                            Difficulty = 4, //find difficulty
                            StoreLink = "https://www.jwpepper.com/sheet-music/10667359.item#.YnAhssjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonta",
                            Composer = "DiPasquale, James",
                            YearPublished = 1967,
                            Difficulty = 6,
                            StoreLink = "https://www.hickeys.com/music/contests/NYSSMA/tenor_saxophone_solos/level_6/products/sku028268-dipasquale-james-sonata.php"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Pitt County Excursions",
                            Composer = "Duckworth, William",
                            YearPublished = 1976,
                            Difficulty = 3, //grades 7-8 (progressive)
                            StoreLink = "https://www.jwpepper.com/Pitt-County-Excursions/10969450.item#.YnAkbMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Adagio and Allegro",
                            Composer = "Handel, G.F.",
                            YearPublished = 1722,
                            Difficulty = 2,
                            StoreLink = "https://www.jwpepper.com/Adagio-and-Allegro/7556152.item#.YnAlL8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Poem",
                            Composer = "Hartley, Walter",
                            YearPublished = 1967,
                            Difficulty = 4,
                            StoreLink = "https://www.jwpepper.com/Poem/4849063.item#.YnAm5cjMKUk"
                        }
                    }
                },
                /*This block contains all the excerpts
                 * for the trombone players
                 */
                {
                    "Trombone", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Morceau Symphonique",
                            Composer = "Guilmant, Alexandre",
                            YearPublished = 1902,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Morceau-Symphonique/1003235.item#.YmsDLcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Blue Bells of Scotland",
                            Composer = "Pryor, Arthur",
                            YearPublished = 1901,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Blue-Bells-of-Scotland/995209.item#.YmsD1cjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Andante et Allegro",
                            Composer = "Barat, Joseph Edouard",
                            YearPublished = 1926,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Andante-et-Allegro/4534608.item#.YmsEKMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata No. 1",
                            Composer = "Galliard, Johann Ernest",
                            YearPublished = 1733,
                            Difficulty = 4, //M
                            StoreLink = "https://www.jwpepper.com/Six-Sonatas/6040257.item#.YmsErcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Trombone Concerto",
                            Composer = "Rimsky-Korsakov, Nikolai",
                            YearPublished = 1877,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Trombone-Concerto/7265077.item#.YmsF6MjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Trombone Concertino",
                            Composer = "David, Ferdinand",
                            YearPublished = 1838,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concertino%2C-Op.-4/2051126.item#.YmsGaMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Trombone Sonata",
                            Composer = "Hindemith, Paul",
                            YearPublished = 1941,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Sonata-for-Trombone-and-Piano/996686.item#.YmsG58jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Trombone Concerto",
                            Composer = "Grondahl, Launy",
                            YearPublished = 1924,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concerto/7171283.item#.YmsuSMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Angels Serenade",
                            Composer = "Braga, Gaetano",
                            YearPublished = 1867,
                            Difficulty = 2,
                            StoreLink = "https://www.jwpepper.com/Angels-Serenade-Trombone-Baritone/5946751.item#.YmsupsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Meditation",
                            Composer = "Buchtel, Forrest",
                            YearPublished = 1945,
                            Difficulty = 1, //E
                            StoreLink = "https://www.jwpepper.com/Meditation/4581716.item#.YmsyG8jMKUk"
                        }
                    }
                },
                /*This block contains all the excerpts
                 * for the trumpet players
                 */
                {
                    "Trumpet", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Trumpet Concerto in E-Flat Major",
                            Composer = "Haydn, Joseph",
                            YearPublished = 1796,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Concerto-for-Trumpet/994053.item#.Ymr3v8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Trumpet Sonata",
                            Composer = "Hindemith, Paul",
                            YearPublished = 1939,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Sonata-for-Trumpet-and-Piano/997007.item#.Ymr4NMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Impromptu",
                            Composer = "Ibert, Jacques",
                            YearPublished = 1951,
                            Difficulty = 4,
                            StoreLink = "https://www.jwpepper.com/Impromptu-for-Trumpet-and-Piano/6382626.item#.Ymr5SMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Polyphony",
                            Composer = "Whittenberg, Charles",
                            YearPublished = 1970,
                            Difficulty = 6,
                            StoreLink = "https://www.sheetmusicplus.com/title/polyphony-sheet-music/20073015"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Cantilena",
                            Composer = "Handel, G.F.",
                            YearPublished = 1740,
                            Difficulty = 2, //E
                            StoreLink = "https://www.jwpepper.com/Cantilena-for-Cornet%2C-Trumpet-or-Baritone-T.C./996272.item#.Ymr64MjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Andante et Allegro",
                            Composer = "Balay, Guillaume",
                            YearPublished = 1910,
                            Difficulty = 4, //MA
                            StoreLink = "https://www.jwpepper.com/Andante-et-Allegretto/4593976.item#.Ymr8dsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Metropolis",
                            Composer = "Vizzutti, Allen",
                            YearPublished = 2002,
                            Difficulty = 3, //M
                            StoreLink = "https://www.jwpepper.com/Metropolis-Trumpet/5977827.item#.Ymr8-sjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Andante et Scherzo",
                            Composer = "Barat, Joseph Edouard",
                            YearPublished = 1920,
                            Difficulty = 4, //MA
                            StoreLink = "https://www.jwpepper.com/Andante-et-Scherzo/4535498.item#.Ymr9sMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Shazam",
                            Composer = "Rabe, Folke",
                            YearPublished = 1984,
                            Difficulty = 6,
                            StoreLink = "https://www.jwpepper.com/Shazam/7812654.item#.Ymr-K8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Contest Piece (Morceau de Concours)",
                            Composer = "Alary, Georges",
                            YearPublished = 1900,
                            Difficulty = 3, //MA
                            StoreLink = "https://www.jwpepper.com/Contest-Piece/4796199.item#.Ymr_jMjMKUk"
                        }
                    }
                },
                /*This block contains all the excerpts
                 * for the tuba players
                 */
                {
                    "Tuba", new List<Excerpt>
                    {
                        new Excerpt
                        {
                            ExcerptTitle = "Concerto for Tuba",
                            Composer = "Vaughan Williams, Ralph",
                            YearPublished = 1954,
                            Difficulty = 6, //A
                            StoreLink = "https://www.jwpepper.com/Concerto-for-Trumpet/994053.item#.Ymr3v8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Asleep in the Deep",
                            Composer = "Petrie, H.W.",
                            YearPublished = 1897,
                            Difficulty = 2, //E but 6/8 time
                            StoreLink = "https://www.jwpepper.com/Asleep-in-the-Deep-Tuba-Solo-------/4846168.item#.YnBPycjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Revenge! Timotheus Cries!",
                            Composer = "Handel, G.F.",
                            YearPublished = 1736,
                            Difficulty = 2, //ME
                            StoreLink = "https://www.jwpepper.com/Revenge-Timotheus-Cries-Tuba-Sol/4607305.item#.YnBQj8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Variations on the Theme of Judas Maccabeus",
                            Composer = "Beethoven, Ludwig van",
                            YearPublished = 1796,
                            Difficulty = 5, //MA
                            StoreLink = "https://www.jwpepper.com/Variations-on-the-Theme-of-Judas-Maccabeus/995233.item#.YnBQBsjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Fantasy for Tuba",
                            Composer = "Arnold, Malcolm",
                            YearPublished = 1969,
                            Difficulty = 3,
                            StoreLink = "https://www.jwpepper.com/Fantasy-for-Tuba%2C-Op.-102/5006762.item#.YnCDAcjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Suite for Tuba",
                            Composer = "Haddad, Don",
                            YearPublished = 1966,
                            Difficulty = 4,
                            StoreLink = "https://www.jwpepper.com/Suite-for-Tuba/1006105.item#.YnCD_8jMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "O Isis and Osiris",
                            Composer = "Mozart, W.A.",
                            YearPublished = 1791,
                            Difficulty = 3, //ME
                            StoreLink = "https://www.jwpepper.com/O-Isis-and-Osiris/4785440.item#.YnCE6sjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Andante and Rondo",
                            Composer = "Capuzzi, Antonio",
                            YearPublished = 1967,
                            Difficulty = 4,
                            StoreLink = "https://www.jwpepper.com/Andante-and-Rondo/4843991.item#.YnCGKMjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Sonata for Tuba",
                            Composer = "Hindemith, Paul",
                            YearPublished = 1955,
                            Difficulty = 5,
                            StoreLink = "https://www.jwpepper.com/Sonata-for-Tuba-and-Piano/996447.item#.YnCGksjMKUk"
                        },
                        new Excerpt
                        {
                            ExcerptTitle = "Encounters II",
                            Composer = "Kraft, William",
                            YearPublished = 1970,
                            Difficulty = 6,
                            StoreLink = "https://www.jwpepper.com/Encounters-Two-Tuba-Solo/7319445.item#.YnCHAcjMKUk"
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
