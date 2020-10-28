using System;

namespace Esercizio_traccia_audio
{
    class Program
    {
        public struct Traccia
        {
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
            int scelta = default(int), inputInt = default(int), num = default(int), x = default(int), y = default(int), sceltaForzata = default;
            string inputStr = default(string);
            decimal media = default(decimal), max = default(decimal), min = default(decimal);
            bool quit = default(bool), trovato = default(bool);
            
            /*num = 0;
            listaTracce[num].codice = "tr1";
            listaTracce[num].titolo = "banana";
            listaTracce[num].nomeFile = "banana.mp4";
            listaTracce[num].durata = 50;
            listaTracce[num].genere = "rock";
            listaTracce[num].prezzo = 400;
            num++;
            listaTracce[num].codice = "tr2";
            listaTracce[num].titolo = "sasso";
            listaTracce[num].nomeFile = "sasso.mp4";
            listaTracce[num].durata = 90;
            listaTracce[num].genere = "rock";
            listaTracce[num].prezzo = 100;
            num++;
            listaTracce[num].codice = "tr3";
            listaTracce[num].titolo = "gorilla";
            listaTracce[num].nomeFile = "gorilla.mp4";
            listaTracce[num].durata = 300;
            listaTracce[num].genere = "pop";
            listaTracce[num].prezzo = 1000;
            num++;
            listaTracce[num].codice = "tr4";
            listaTracce[num].titolo = "mandrillo";
            listaTracce[num].nomeFile = "mandrillo.mp4";
            listaTracce[num].durata = 20;
            listaTracce[num].genere = "pop";
            listaTracce[num].prezzo = 400;
            num++;*/

            while (!quit)
            {
                if (sceltaForzata == 0)
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
                    Console.WriteLine("#  7) Traccia prezzo + basso   #");
                    Console.WriteLine("#                              #");
                    Console.WriteLine("################################");
                    Console.WriteLine("#  0) Esci                     #");
                    Console.WriteLine("################################");
                    scelta = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                } else
                {
                    scelta = sceltaForzata;
                }
                Console.Clear();
                sceltaForzata = 0;
                y = 0;
                x = 0;
                max = 0;
                min = 0;
                media = default;
                inputInt = default;
                inputStr = default;
                trovato = default;




                switch (scelta)
                {
                    case 0:
                        {
                            quit = true;
                            break;
                        }
                    case 1:
                        {
                            do
                            {
                                Console.WriteLine("################################");
                                Console.Write("Codice traccia: ");
                                listaTracce[num].codice = Console.ReadLine();
                                Console.Write("Titolo traccia: ");
                                listaTracce[num].titolo = Console.ReadLine();
                                Console.Write("Nome file traccia: ");
                                listaTracce[num].nomeFile = Console.ReadLine();
                                Console.Write("Durata traccia in secondi: ");
                                listaTracce[num].durata = int.Parse(Console.ReadLine());
                                Console.Write("Genere traccia: ");
                                listaTracce[num].genere = Console.ReadLine();
                                Console.Write("Prezzo traccia: ");
                                listaTracce[num].prezzo = Decimal.Parse(Console.ReadLine());
                                num++;
                                Console.WriteLine("################################");
                                Console.WriteLine("Aggiungere un altra traccia? [S/N]");
                            } while (Console.ReadKey(true).KeyChar == 's');
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Inserisci il codice della traccia da modificare: ");
                            inputStr = Console.ReadLine();
                            while (x < num && !trovato)
                            {
                                if (listaTracce[x].codice == inputStr)
                                {
                                    trovato = true;
                                }
                                else
                                {
                                    x++;
                                }
                            }

                            if (trovato)
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
                                if (Console.ReadKey(true).KeyChar == 's')
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
                            }
                            else
                            {
                                Console.WriteLine("Nessuna traccia trovata con codice " + inputStr);
                            }
                            break;
                        }
                    case 3:
                        {
                            while (x < num)
                            {
                                Console.WriteLine("################################");
                                Console.WriteLine($"Codice: {listaTracce[x].codice}");
                                Console.WriteLine($"Titolo: {listaTracce[x].titolo}");
                                Console.WriteLine($"File  : {listaTracce[x].nomeFile}");
                                Console.WriteLine($"Durata: {listaTracce[x].durata} secondi");
                                Console.WriteLine($"Genere: {listaTracce[x].genere}");
                                Console.WriteLine($"Prezzo: {listaTracce[x].prezzo} euro");
                                x++;
                            }
                            Console.WriteLine("################################");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Cancellazione tracce, inserisci la durata minima delle tracce: ");
                            inputInt = int.Parse(Console.ReadLine());
                            while (x < num)
                            {
                                if (listaTracce[x].durata <= inputInt)
                                {
                                    num--;
                                    y = x;
                                    while (y < num)
                                    {
                                        if (y != listaTracce.Length - 1)
                                        {
                                            listaTracce[y] = listaTracce[y + 1];
                                            
                                            y++;
                                        }
                                    }
                                    x--;
                                }

                                x++;
                            }
                            
                        }
                        Console.WriteLine("Cancellate tutte le tracce con durata inferiore a " + inputInt + " secondi");
                        break;
                    case 5:
                        {
                            Console.Write("Inserisci la categorie delle tracce per cui calcolare la media: ");
                            inputStr = Console.ReadLine();
                            while (x < num)
                            {
                                if (listaTracce[x].genere == inputStr)
                                {
                                    media += listaTracce[x].prezzo;
                                    y++;
                                }
                                x++;
                            }

                            if (y == 0)
                            {
                                Console.WriteLine("Nessuna traccia trovata...");
                                break;
                            }
                            media /= y;
                            Console.WriteLine($"La media dei prezzi delle tracce nella categoria {inputStr} è di {media} euro");
                            break;
                        }
                    case 6:
                        {
                            while (x < num)
                            {
                                if (listaTracce[x].prezzo > max)
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
                    case 7:
                        {
                            if(num == 0)
                            {
                                Console.WriteLine("Non ci sono tracce, devi inserire un prodotto");
                                sceltaForzata = 1;
                                break;
                            }

                            min = listaTracce[0].prezzo;
                            while (x < num)
                            {
                                if(listaTracce[x].prezzo < min)
                                {
                                    Console.WriteLine(listaTracce[x].prezzo);
                                    min = listaTracce[x].prezzo;
                                    y = x;
                                }
                                x++;
                            }
                            Console.WriteLine("La traccia che costa di meno è:");
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
