namespace ConsoleApp3;

public class Plynowy : Kontener, IHazardNotifier
{
    private bool _niebezpieczny;
    private double _aktualnaWaga;
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
        if (_aktualnaWaga+waga > maxLadownosc)
        {
            _aktualnaWaga += waga;
        }
    }


    public void Notify(string contId)
    {
        Console.WriteLine("niebezpieczna sytuacja w kontenerze " + contId);
    }
}