namespace ConsoleApp3;
public class Chlodniczy : Kontener
{
    private string rodzajProduktu;
    private double temp;

    public double Temp
    {
        get => temp;
        set => temp = value;
    }


    public Chlodniczy(double wysokosc, double glebokosc, double wagaWlasna, double masaladunku, double maxLadownosc, string rodzajProduktu, double temp) : base(wysokosc, glebokosc, wagaWlasna, masaladunku, maxLadownosc)
    {
        this.rodzajProduktu = rodzajProduktu;
        this.temp = temp;
        this.numSer = "KON-C-" + counter++;

    }
}