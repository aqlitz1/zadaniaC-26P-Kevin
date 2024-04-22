class Program
{
    static void Main(String[] args)
    {
        string nr_pesel = "12345678901";
        Console.WriteLine("Podaj nr pesel: ");
        nr_pesel = Console.ReadLine();

        Console.WriteLine($"Płeć: {Sprawdzanie_Plci(nr_pesel)}");
    }
    static char Sprawdzanie_Plci(string nr_pesel)
    {
        char plec = 'N';


        int liczba_pesel = Convert.ToInt32(nr_pesel[9]);
        if (liczba_pesel % 2 == 0)
        {
            plec = 'K';
        }
        else
        {
            plec = 'M';
        }
        return plec;
    }

    static bool Numer_Kontrolny(string nr_pesel)
    {
        bool prawidlowy = false;

        int S = 0;
        int waga = 0;
        for (int i = 0; i < 10;  i++)
        {
            if(i == 0)
            S = S + Convert.ToInt32(nr_pesel[i]); * 
        }
    }
}
