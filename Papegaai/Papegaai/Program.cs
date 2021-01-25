using System;

namespace Papegaai
{
    class Program
    {
        static void Main(string[] args)
        {

            Papegaai p1 = new Papegaai("Bartel", 4, "oranje");
            Papegaai p2 = new Papegaai();
            Console.WriteLine(p2.naam);
            p1.zeg("");
            p1.zegRandom(10);
            p1.Voer("chips");
            p1.art();

        }

        //class
        class Papegaai
        {
            //fields
            public string naam;
            public int leeftijd;
            public string verenkleur;
            public static string[] woordenLijst = new string[10] { "Hallo", "huis", "banaan", "voetbal", "ster", "kikker", "komkommer", "rood", "zee", "jan" };
            public string[] lekkerEten = new string[10] { "nootjes", "pitjes", "appelmoes", "kikkererwten", "wormen", "pizza", "zaadjes", "kaas", "pindakaas", "confituur" };
            //end fields

            //constructors
            public Papegaai (string naam, int leeftijd, string verenkleur)
            {
                this.naam = naam;
                this.leeftijd = leeftijd;
                this.verenkleur = verenkleur;
            }

            public Papegaai()
            {
                this.naam = "naamloos";
                this.leeftijd = 0;
                this.verenkleur = "kleurloos";
            }
            //end constructors
            
            //methods
            public void zeg(string woord) 
            {

                if (woord == "")
                {
                    Console.WriteLine("Geen woord ingegeven.");
                } else 
                {
                    for (int i = woord.Length - 1; i >= 0; i--)
                    {
                        Console.Write(woord[i]);
                    }
                    Console.WriteLine("\n");
                }
            }

            public void zegRandom()
            {
                Random rnd = new Random();
                int rndGetal = rnd.Next(0, 10);

                Console.WriteLine(woordenLijst[rndGetal]);
            }

            public void zegRandom(int aantal)
            {
                Random rnd = new Random();
                int rndGetal = rnd.Next(0, 11);

                for (int i = 0; i < aantal; i++)
                {
                    Console.WriteLine(woordenLijst[rndGetal]);
                }

            }

            public void Voer(string eten)
            {
                string voer = "";

                foreach (string lekker in lekkerEten)
                {
                    if (eten == lekker)
                    {
                        voer = "lekker";
                        break;
                    } else
                    {
                        voer = "lust ik niet";
                    }
                }
                Console.WriteLine(voer);
            }

            public void art()
            {
                
                Console.WriteLine(
"\n\n\n        )_)_)__)_)_)_)__)_.                                      \n" +
"         )_))_))_ _))_ ))) )                                     \n" +
"         )_))  )~)  )_))~)  )                                    \n" +
"          )  ) )  )_) )  ) ) )  )                                \n" +
"          )  )))  ) )  ) )~_)   ))                               \n" +
"          | _(~((~C(C((_(~(                                      \n" +
"         (~(C(((~((C(~C(                                         \n" +
"        _(_((~(_ = ~_C(~                                         \n" +
"        (((_C = (~~                                              \n" +
"        (_    __   ~~~== (X                                      \n" +
"        _(_  _@@_  _     ~(C_                                    \n" +
"      C(~(_ ~((~(_      ~(C_                                     \n" +
"     (~_C(_       _((C_                                          \n" +
"     (C_C(C_(_ = ~(C_                                            \n" +
"       ~(C((C                                                    \n" +
"          _(~(_                                                  \n" +
"          (_(C                                                   \n" +
"          (~C      ~(_                                           \n" +
"          ((_(C                                                  \n" +
"          (_                     ~C       ~(                     \n" +
"           (_(_      ~(                                          \n" +
"            (_                      ~C      ~(                   \n" +
"             (C                       ~= _(C                     \n" +
"              ~(_                       ~C  C~(                  \n" +
"                (C                      _ ~C(~(                  \n" +
"                 ~(C_         _((_(C                             \n" +
"                    ((C_      ~C    C(((_                        \n" +
"                    (C ~(C_(_(((((_                              \n" +
"                     (_  _((C__((_(_(_(_(_                       \n" +
"         _________C = (~~X((__(_XX(== (X_(__(__(___X(_(C________ \n" +
"        | ~(_CX C~C(~_ C(C~~|                                    \n" +
"        | _(~(((= (_C((_  _ |                                    \n" +
"         ~~~~~~~~~~~~~~~~(~~(~~| (~~~~| ~(~(~~~(~~(X~(X~(~~~~~~  \n" +
"                         ((  |     | (((((CXC~(                  \n" +
"                         (C ~C |     | (_(_((~~~                 \n" +
"                          (_(_ |     | C(_ ~C ~C(                \n" +
"                           ~~~~|     | ~(_~= _(C((~              \n" +
"                               |     | ~(C_~(~                   \n" +
"                               |     |                           \n" +
"                               |     |                           \n" +
"                               |     |                           \n" +
"                               |     |                           \n" +
"/ ______________________________________________________________________\\ \n "+
"\\                                                                       / \n"+
 "_______________________________________________________________________   \n");
            }

            //end methods

        }
    }
}
