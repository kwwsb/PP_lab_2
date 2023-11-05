internal class Program
{
    private static void Main(string[] args)
    {
        //zad 1
        Console.WriteLine("Hello, World! To jest mój pierwszy program");


        //zad2
        Console.WriteLine(" "); //spacja
        Console.WriteLine("\n"); //enter
        Console.WriteLine("\t"); //tab


        //zad4
        Console.WriteLine("tekst" == "tekst"); //T
        Console.WriteLine("K" == "k"); //F
        Console.WriteLine(1 == 4); //F
        string myValue = "K";
        Console.WriteLine(myValue == "K"); //T
        Console.WriteLine(1 > 5); //F
        Console.WriteLine(1 < 5); //T
        Console.WriteLine(1 >= 5); //F
        Console.WriteLine(1 <= 5); //T

        Console.WriteLine("\n");

        //zad5
        string test = "Moj pierwszy program";
        Console.WriteLine(test.Substring(4, 2));
        /* w pierwszej linijce definiujemy string "test", 
         * a w drugiej linijce wyświetlamy czwarty i drugi znak pobrany ze stringu "test", czyli "pi"*/

        Console.WriteLine("\n");

        //zad6
        //a)
        int mojWiek = 50;
        int twojWiek = mojWiek > 40 ? 40 : 20;
        Console.WriteLine($"Twój Wiek: {twojWiek}");
        /*działanie kodu polega na sprawdzeniu czy zmienna mojWiek przechowuje wartość mniejszą czy większą od 40
         *jeśli większą, to wyświetla w konsoli 40, jeśli mniejszą to 20 
         *wynik sprawdzenia przypisywany jest do zmiennej twojWiek*/

        //b)
        int mojWiek1 = 50;
        int twojWiek1 = mojWiek1 < 40 ? 40 : 20;
        Console.WriteLine($"Twój Wiek: {twojWiek1}");
        /*w podpunkcie b) zmieniony został warunek
        teraz jeśli zmienna mójWiek1 jest mniejsza to wyświetlamy w konsoli 40, jeśli większa to 20*/

        Console.WriteLine("\n");

        //zad7
        //a)
        string imie = "Jan ";
        string nazwisko = "Kowalski";
        string imie2 = imie + nazwisko;
        Console.WriteLine(imie2);

        //b)
        string imie3 = string.Concat(imie, nazwisko);
        Console.WriteLine(imie3);

        //c)
        string imie4 = "Jan";
        string imie5 = $"Moje imie i nazwisko to: {imie4} {nazwisko}";
        Console.WriteLine(imie5);

        /*wszystkie trzy podpunkty łączą dwa stringi w jeden (konkatenacja), ale realizują to na inne sposoby:
         *w podpunkcie a) realizowane jest to za pomocą utworzenia nowej zmiennej, która "dodaje" string imie do stringu nazwisko
         *w podpunkcie b) realizowane jest to za pomocą polecenia "string.Concat()"
         *w podpunkcie c) realizowane jest to za pomocą interpolacji ciągu
         */

        Console.WriteLine("\n");

        //zad8
        /* symbol $ oznacza interpolację ciągu, dzięki której można wstawić wartości do pojedynczego ciągu wynikowego.*/

        //zad9
        Console.WriteLine("Podaj wiek:");
        string userAge = Console.ReadLine();
        Console.WriteLine("Podaj imię:");
        string userName = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko:");
        string userSurname = Console.ReadLine();
        Console.WriteLine($"Wiek: {userAge} Imię: {userName} Nazwisko: {userSurname}");

        Console.WriteLine("\n");

        //zad11
        int mojNumer = 7;
        double mojdoubleNumer = 7.99D;
        char mojaLitera = 'D';
        bool mojLogika = true;
        string mojTekst = "Hello";
        Console.WriteLine(mojNumer);
        Console.WriteLine(mojdoubleNumer);
        Console.WriteLine(mojaLitera);
        Console.WriteLine(mojLogika);
        Console.WriteLine(mojTekst);

        Console.WriteLine("\n");

        //zad12
        //int mojNumer = 5;
        int _mojNumer = 5;
        //int 5mojNumer = 5;
        //int moj Numer = 5;
        //int % mojNumer = 5;
        int MojNumer = 5;
        /*nie można zadeklarować zmiennych o tej samej nazwie, zaczynających się od cyfr, 
         * ze spacjami, ani zaczynających się od znaku % */

        //zad13
        DateTime dzisiejszaData = DateTime.Now;
        Console.WriteLine(dzisiejszaData);

    }
}



//zad10
/* Słowo kluczowe namespace służy do deklarowania zakresu zawierającego zestaw powiązanych obiektów. 
 * Przestrzeń nazw umożliwia organizowanie elementów kodu i tworzenie unikatowych typów globalnych. */
namespace zad10
{
    class Program
    {
        static void zad10()
        {
            string imie = "Jan";
            string nazwisko = "Kowalski";
            string razem = imie + nazwisko;

        }
    }
}


    

