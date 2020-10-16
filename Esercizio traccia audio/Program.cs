using System;

namespace Esercizio_traccia_audio
{
    class Program
    {
        public struct Traccia {
            public string codice;
            public string titolo;
            public string nomeFile;
            public int durata;
            public string genere;
            public decimal prezzo;
        }

        static void Main(string[] args)
        {
            Traccia[] listaTracce = new Traccia[1000];
            int scelta = default(int), inputInt = default(int), id = default(int), x = default(int), y = default(int);
            string inputStr = default(string);
            decimal media = default(decimal), max = default(decimal);
            bool quit = default(bool), trovato = default(bool);
            id = 0;

            listaTracce[id].codice = "tr1";
            listaTracce[id].titolo = "banana";
            listaTracce[id].nomeFile = "banana.mp4";
            listaTracce[id].durata = 50;
            listaTracce[id].genere = "rock";
            listaTracce[id].prezzo = 400;
            id++;
            listaTracce[id].codice = "tr2";
            listaTracce[id].titolo = "sasso";
            listaTracce[id].nomeFile = "sasso.mp4";
            listaTracce[id].durata = 90;
            listaTracce[id].genere = "rock";
            listaTracce[id].prezzo = 100;
            id++;
            listaTracce[id].codice = "tr3";
            listaTracce[id].titolo = "gorilla";
            listaTracce[id].nomeFile = "gorilla.mp4";
            listaTracce[id].durata = 300;
            listaTracce[id].genere = "pop";
            listaTracce[id].prezzo = 1000;
            id++;
            listaTracce[id].codice = "tr4";
            listaTracce[id].titolo = "mandrillo";
            listaTracce[id].nomeFile = "mandrillo.mp4";
            listaTracce[id].durata = 20;
            listaTracce[id].genere = "pop";
            listaTracce[id].prezzo = 400;
            id++;

            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("################################");
                Console.WriteLine("#             Menù             #");
                Console.WriteLine("################################");
                Console.WriteLine("#                              #");
                Console.WriteLine("#  1) Aggiungi traccia         #");
                Console.WriteLine("#  2) Modifica traccia         #");
                Console.WriteLine("#  3) Mostra tracce            #");
                Console.WriteLine("#  4) Cancella tracce          #");
                Console.WriteLine("#  5) Prezzo medio tracce      #");
                Console.WriteLine("#  6) Traccia prezzo + alto    #");
                Console.WriteLine("#                              #");
                Console.WriteLine("################################");
                Console.WriteLine("#  0) Esci                     #");
                Console.WriteLine("################################");
                scelta = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                Console.Clear();
                y = 0;
                x = 0;
                inputInt = default(int);
                inputStr = default(string);
                trovato = default(bool);

                


                switch (scelta)
                {
                    case 1:
                        {
                            do
                            {
                                Console.WriteLine("################################");
                                Console.Write("Codice traccia: ");
                                listaTracce[id].codice = Console.ReadLine();
                                Console.Write("Titolo traccia: ");
                                listaTracce[id].titolo = Console.ReadLine();
                                Console.Write("Nome file traccia: ");
                                listaTracce[id].nomeFile = Console.ReadLine();
                                Console.Write("Durata traccia in secondi: ");
                                listaTracce[id].durata = int.Parse(Console.ReadLine());
                                Console.Write("Genere traccia: ");
                                listaTracce[id].genere = Console.ReadLine();
                                Console.Write("Prezzo traccia: ");
                                listaTracce[id].prezzo = Decimal.Parse(Console.ReadLine());
                                id++;
                                Console.WriteLine("################################");
                                Console.WriteLine("Aggiungere un altra traccia? [S/N]");
                            } while (Console.ReadKey(true).KeyChar == 's');
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Inserisci il codice della traccia da modificare: ");
                            inputStr = Console.ReadLine();
                            while (x < id && !trovato)
                            {
                                if(listaTracce[x].codice == inputStr)
                                {
                                    trovato = true;
                                } else
                                {
                                    x++;
                                }
                            }

                            if(trovato)
                            {
                                Console.WriteLine("################################");
                                Console.WriteLine($"Codice: {listaTracce[x].codice}");
                                Console.WriteLine($"Titolo: {listaTracce[x].titolo}");
                                Console.WriteLine($"File  : {listaTracce[x].nomeFile}");
                                Console.WriteLine($"Durata: {listaTracce[x].durata}");
                                Console.WriteLine($"Genere: {listaTracce[x].genere}");
                                Console.WriteLine($"Prezzo: {listaTracce[x].prezzo}");
                                Console.WriteLine("################################");
                                Console.WriteLine("Vuoi modificare questa traccia? [S/N]");
                                if(Console.ReadKey(true).KeyChar == 's')
                                {
                                    Console.WriteLine("################################");
                                    Console.Write("Codice: ");
                                    listaTracce[x].codice = Console.ReadLine();
                                    Console.Write("Titolo: ");
                                    listaTracce[x].titolo = Console.ReadLine();
                                    Console.Write("File  : ");
                                    listaTracce[x].nomeFile = Console.ReadLine();
                                    Console.Write("Durata: ");
                                    listaTracce[x].durata = int.Parse(Console.ReadLine());
                                    Console.Write("Genere: ");
                                    listaTracce[x].genere = Console.ReadLine();
                                    Console.Write("Prezzo: ");
                                    listaTracce[x].prezzo = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("################################");
                                    Console.WriteLine("Traccia modificata con successo");
                                }
                            } else
                            {
                                Console.WriteLine("Nessuna traccia trovata con codice " + inputStr);
                            }
                            break;
                        }
                    case 3:
                        {
                            while(x < id)
                            {
                                if (listaTracce[x].codice != null)
                                {
                                    Console.WriteLine("################################");
                                    Console.WriteLine($"Codice: {listaTracce[x].codice}");
                                    Console.WriteLine($"Titolo: {listaTracce[x].titolo}");
                                    Console.WriteLine($"File  : {listaTracce[x].nomeFile}");
                                    Console.WriteLine($"Durata: {listaTracce[x].durata} secondi");
                                    Console.WriteLine($"Genere: {listaTracce[x].genere}");
                                    Console.WriteLine($"Prezzo: {listaTracce[x].prezzo} euro");
                                }
                                x++;
                            }
                            Console.WriteLine("################################");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Cancellazione tracce, inserisci la durata minima delle tracce: ");
                            inputInt = int.Parse(Console.ReadLine());
                            while(x < id)
                            {
                                if(listaTracce[x].durata < inputInt)
                                {
                                    Console.WriteLine(listaTracce[x].titolo + " cancellata");
                                    listaTracce[x] = default(Traccia);
                                }
                                x++;
                            }
                            Console.WriteLine("Cancellate tutte le tracce con durata inferiore a " + inputInt + " secondi");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Inserisci la categorie delle tracce per cui calcolare la media: ");
                            inputStr = Console.ReadLine();
                            while(x < id)
                            {
                                if(listaTracce[x].codice != null)
                                {
                                    media += listaTracce[x].prezzo;
                                    y++;
                                }
                                x++;
                            }

                            if(y == 0)
                            {
                                Console.WriteLine("Nessuna traccia trovata...");
                            } else
                            {
                                media /= y;
                                Console.WriteLine($"La media dei prezzi delle tracce nella categoria {inputStr} è di {media} euro");
                            }
                            break;
                        }
                    case 6:
                        {
                            while (x < id)
                            {
                                if(listaTracce[x].prezzo > max)
                                {
                                    max = listaTracce[x].prezzo;
                                    y = x;
                                }
                                x++;
                            }
                            Console.WriteLine("La traccia che costa di più è:");
                            Console.WriteLine("################################");
                            Console.WriteLine($"Codice: {listaTracce[y].codice}");
                            Console.WriteLine($"Titolo: {listaTracce[y].titolo}");
                            Console.WriteLine($"File  : {listaTracce[y].nomeFile}");
                            Console.WriteLine($"Durata: {listaTracce[y].durata} secondi");
                            Console.WriteLine($"Genere: {listaTracce[y].genere}");
                            Console.WriteLine($"Prezzo: {listaTracce[y].prezzo} euro");
                            Console.WriteLine("################################");
                            break;
                        }
                }
                Console.Write("\nPremi un tasto per tornare al menù...");
                Console.ReadKey();
            }
        }
    }
}
