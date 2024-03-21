namespace ConsoleApp3;
public class Chlodniczy : Kontener, IHazardNotifier
{
    private string _rodzajProduktu;
    private double _temp;
    private double _minTemp;
    
    public Chlodniczy(double wysokosc, double glebokosc, double wagaWlasna, double masaladunku, double maxLadownosc, string rodzajProduktu, double temp) : base(wysokosc, glebokosc, wagaWlasna, masaladunku, maxLadownosc)
    {
        this._rodzajProduktu = rodzajProduktu;
        this._temp = temp;
        this._minTemp = temp;
        this.NumSer = "KON-C-" + Counter++;

    }

    public double Temp
    {
        get => _temp;
        set
        {
            if (value > _minTemp)
            {
                Notify(this.NumSer);
            }
            else
            {
                _temp = value;
            }
        }
    }

    public override string ToString()
    {
        return base.ToString() + ", " + _rodzajProduktu + ", " + _temp + "]";
    }

    public void Notify(string contId)
    {
        Console.WriteLine("zbyt wysoka temperatura w kontenerze " + contId + " nie dokonano zmiany");
    }
}