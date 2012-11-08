using System;
using System.Collections.Generic;
using System.Text;

namespace WlasciwosciKlasyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.BufferHeight - liczba dostępnych wierszy w okienku
            Console.BufferHeight = 30;
            // Console.WindowHeight - liczba widocznych wierszy w oknie. 
            // Musi być ona mniejsza od właściwości Console.LargestWindowHeight,
            // która oznacza maksymalną ilość wierszy,
            // wyznaczoną w oparciu o bieżącą wielkość fontu i rozdzielczość ekranu.
            Console.WindowHeight =          //wysokość okna
                Console.BufferHeight < Console.LargestWindowHeight ? Console.BufferHeight : Console.LargestWindowHeight;  //wyznaczenie minimum

            // Console.BufferWidth - liczba dostępnych kolumn w okienku.
            // Musi być ona mniejsza od właściwości Console.LargestWindowWidth,
            // która oznacza maksymalną ilość kolumn,
            // wyznaczoną w oparciu o bieżącą wielkość fontu i rozdzielczość ekranu.
            Console.BufferWidth = 80;
            // Console.WindowWidth - liczba widocznych kolumn w oknie.
            Console.WindowWidth =           //szerokość okna
                Console.BufferWidth < Console.LargestWindowWidth ? Console.BufferWidth : Console.LargestWindowWidth;    //wyznaczenie minimum
            
            char c;
            do
            {
                //Przedstawienie Menu - co program robi

                // Console.BackgroundColor - kolor tła
                Console.BackgroundColor = ConsoleColor.Blue;
                // Console.ForegroundColor - kolor czcionki
                Console.ForegroundColor = ConsoleColor.Yellow;
                // Console.Clear() - wyczyszczenie całego okna, zamazanie kolorem tła
                Console.Clear();
                // Console.CursorLeft - numer kolumny, gdzie znajduje się kursor.
                // Kolumny są numerowane od lewej do prawej strony okna.
                Console.CursorLeft = Console.WindowWidth / 2 - 15;
                // Console.CursorTop - numer wiersza, gdzie znajduje się kursor.
                // Wiersze są numerowane od góry do dołu okna.
                Console.CursorTop = Console.WindowHeight / 2 - 8;
                Console.WriteLine("Menu");
                // Console.SetCursorPosition(kolumna, wiersz) 
                // - ustawienie pozycji kursora,
                // czyli gdzie będzie rozpoczynać się operacja wypisania na ekranie
                Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 7);
                Console.WriteLine("__________________________________________");

                Console.CursorLeft = Console.WindowWidth / 2 - 10;
                Console.CursorTop = Console.WindowHeight / 2 - 5;
                Console.WriteLine("A - Wiadomości sportowe");
                Console.CursorLeft = Console.WindowWidth / 2 - 10;
                Console.CursorTop = Console.WindowHeight / 2 - 2;
                Console.WriteLine("B - Pogoda");
                Console.CursorLeft = Console.WindowWidth / 2 - 10;
                Console.CursorTop = Console.WindowHeight / 2 + 1;
                Console.WriteLine("C - Humor");
                Console.CursorLeft = Console.WindowWidth / 2 - 10;
                Console.CursorTop = Console.WindowHeight / 2 + 4;
                Console.WriteLine("K - Koniec");

                // Console.ReadKey(true).KeyChar 
                // - wartość typu char naciśniętego klawisza.
                // pobranie polecenia użytkownika
                c = Console.ReadKey(true).KeyChar;


                // Console.Beep(czestotlowosc, czas) 
                // - wydanie dźwięku o danej częstotliwość podanej w Hz,
                // przez określony czas podany w ms.


                //przetwarzanie polecenie użytkownika
                switch (c)
                {
                    case 'a':
                    case 'A':
                        Console.Beep (500, 1000);
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 5);
                        Console.WriteLine("Polska po raz trzeci z rzędu mistrzem świata.");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 3);
                        Console.WriteLine("W meczu finałowym pokonała Brazylię 3 : 0.");
                        Console.ReadKey();
                        break;
                    case 'b':
                    case 'B':
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 5);
                        Console.WriteLine("W Bałtyku temperatura wody wynosi 25 stopni Celsjusza.");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 3);
                        Console.WriteLine("Na Kasprowym znakomite warunki narciarskie.");
                        Console.ReadKey();
                        break;
                    case 'c':
                    case 'C':
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 5);
                        Console.WriteLine("Oprogramowanie jest jak katedra.");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 3);
                        Console.WriteLine("Budujesz, budujesz, a potem... już tylko się modlisz!");
                        Console.ReadKey();
                        break;
                }
            }
            while (!(c == 'k' || c == 'K'));
        }
    }
}
