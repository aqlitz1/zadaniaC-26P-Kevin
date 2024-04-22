namespace Powtorzeniowy
{
    public class PlikGłówny
    {
        static void Main(string[] args)
        {
            Tablice tablica = new Tablice();
            
            int[] tab = tablica.Tworzenie_Tablicy();
            tablica.Wyswietl(tab);
            tablica.SortujBabelkowo(tab);
            tablica.Wyswietl(tab);
        }



    }
}
