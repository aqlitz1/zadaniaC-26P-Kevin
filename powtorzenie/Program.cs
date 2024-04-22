using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Powtorzeniowy
{
    public class Tablice
    {
        public void Wyswietl(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + ", ");
            }
        }
        public int [] Tworzenie_Tablicy()
        {
            Console.WriteLine("Ile znaków ma mieć tablica? ");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];

            for(int i = 0; i < dl; i++)
            {
                Console.Write("Podaj kolejny element: ");
                ints[i] = int.Parse(Console.ReadLine()) ;
            
            
            
            
            
            
            } return ints;
       } 
    public void SortujBabelkowo(int[] tablica)
        {
            for(int i = 0; i < tablica.Length;i++)
            {
                for(int j=1; j< tablica.Length;j++)
                {
                    if (tablica[j-1] > tablica[j])
                    {
                        int temp = tablica[j-1];
                        tablica[j-1] = tablica[j];
                        tablica[j] = temp;
                    }
                }
            }
        }
    public void Przeszukaj(int[] tab)
        {
            bool liczba = false;
            int x = 0;
            Console.Write("Jakiej liczby szukasz w tablicy? : ");
            int szukana = int.Parse(Console.ReadLine());
            for(int i = 0; i < tab.Length;i++)
            {
                if (tab[i] == szukana)
                {
                    liczba == true;
                    x++;
                }
            }
            if (liczba == true)
            {
                Console.WriteLine("Liczba znajduje się w tablicy, występuje " + x + "razy");
            }
            else
            {
                Console.WriteLine("Liczba nie znajduje się w tablicy");
            }
        
        }
    
   
    
    
    }
}
