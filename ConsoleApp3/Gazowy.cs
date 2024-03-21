namespace ConsoleApp3;

public class Gazowy : Kontener, IHazardNotifier
{
    private double _pressure;

    public Gazowy(double wysokosc, double glebokosc, double wagaWlasna, double masaladunku, double maxLadownosc, double pressure) : base(wysokosc, glebokosc, wagaWlasna, masaladunku, maxLadownosc)
    {
        this._pressure = pressure;
        this.NumSer = "KON-G-" + Counter++;

    }

    public void Notify(string contId)
    {
        Console.WriteLine("niebezpieczna sytuacja w kontenerze " + contId);
    }

    public override string ToString()
    {
        return base.ToString() + ", " + _pressure + "]";
    }

    public override void Oproznij()
    {
        masaladunku = 0.05;
    }
}