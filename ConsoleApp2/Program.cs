using System.Data;

class Samochod
{
    public string nazwa = "Warburg";
    public string marka;
    public int poziom_paliwa;
    public void zatrąb()
    {
        System.Console.WriteLine("Pip! Pip! ");
    }
    public void zatankuj(int ilosc_paliwa)
    {
        poziom_paliwa += ilosc_paliwa;
        System.Console.WriteLine("Zatankowany o " + ilosc_paliwa + " litry ");
    }
    public void jedź()
    {
        if (poziom_paliwa < 1)
            System.Console.WriteLine("Zbiornik pusty, nigdzie nie jadę! ");
        else
        {
            poziom_paliwa -= 10;
            System.Console.WriteLine("Jadę! ");
        }
    }
    public void kilometry()
    {
        Console.WriteLine("ło panie nie tak szybko ");
    }
}
class kierowca
{
    public void dane()
    {
        Console.WriteLine("podaj imie: ");
        string imie = Console.ReadLine();

        Console.WriteLine("podaj nazwisko: ");
        string nazwisko = Console.ReadLine();

        Console.WriteLine("Podaj wiek: ");
        int wiek = int.Parse(Console.ReadLine());

        if (wiek < 18)
        {
            Console.WriteLine($"{imie} {nazwisko} - Nie Może prowadzić");
        }
        else
        {
            Console.WriteLine($"{imie} {nazwisko} - Moze prowadzic");
        }
    }
}
class program
{
    static void Main(string[] args)
    {
        Samochod A = new Samochod();
        A.marka = "moja marka";
        A.jedź();
        A.zatankuj(20);
        A.jedź();
        A.kilometry();
        kierowca B = new kierowca();
        B.dane();

    }
}