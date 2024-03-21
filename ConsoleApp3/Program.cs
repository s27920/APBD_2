// See https://aka.ms/new-console-template for more information

abstract class Kontener
{
    protected double wysokosc;
    protected double glebokosc;
    protected double wagaWlasna;
    protected double masaladunku;
    protected string numSer;
    protected double maxLadownosc;

    public static int counter = 0;

    protected Kontener(double wysokosc, double glebokosc, double wagaWlasna, double masaladunku, double maxLadownosc)
    {
        this.wysokosc = wysokosc;
        this.glebokosc = glebokosc;
        this.wagaWlasna = wagaWlasna;
        this.masaladunku = masaladunku;
        this.maxLadownosc = maxLadownosc;
    }
    public virtual void oproznij()
    {
        masaladunku = 0;
    }
    
    public virtual void Zaladuj(double waga)
    {
        if (waga > this.maxLadownosc)
        {
            throw new OverFillException("zbyt duży ładunek");
        }
        masaladunku = waga;
    }
}

class Chlodniczy : Kontener
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

class Gazowy : Kontener, IHazardNotifier
{
    private double pressure;

    public Gazowy(double wysokosc, double glebokosc, double wagaWlasna, double masaladunku, double maxLadownosc, double pressure) : base(wysokosc, glebokosc, wagaWlasna, masaladunku, maxLadownosc)
    {
        this.pressure = pressure;
        this.numSer = "KON-G-" + counter++;

    }

    public void Notify(string contId)
    {
        throw new Notify(contId);
    }

    public override void oproznij()
    {
        masaladunku = 0.05;
    }
}

class Plynowy : Kontener, IHazardNotifier
{
    private bool _niebezpieczny;
    public Plynowy(double wysokosc, double glebokosc, double wagaWlasna, double masaladunku, double maxLadownosc, bool niebezpieczny) : base(wysokosc, glebokosc, wagaWlasna, masaladunku, maxLadownosc)
    {
        this._niebezpieczny = niebezpieczny;
        this.numSer = "KON-P-" + counter++;

        if (_niebezpieczny)
        {
            base.maxLadownosc *= 0.5;
        }
        else
        {
            maxLadownosc *= 0.9;
        }
    }

    public override void Zaladuj(double waga)
    {
        if (waga > maxLadownosc)
        {
            Notify(this.numSer);
        }
    }

    public void Notify(string contId)
    {
        throw new Notify(this.numSer);
    }
}

public interface IHazardNotifier
{
    public void Notify(String contId);
}

public class OverFillException : Exception
{
    public OverFillException(string? message) : base(message)
    {
    }
}

public class Notify : Exception
{
    public Notify(string? message, String id) : base(message)
    {
        Console.WriteLine(message);
        Console.WriteLine("kontener " + id);
    }

    public Notify(String id)
    {
        Console.WriteLine("niebezpieczna sytuacja w kontenerze " + id);
    }
}
