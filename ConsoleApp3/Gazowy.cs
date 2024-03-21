namespace ConsoleApp3;

public class Gazowy : Kontener, IHazardNotifier
{
    private double pressure;

    public Gazowy(double wysokosc, double glebokosc, double wagaWlasna, double masaladunku, double maxLadownosc, double pressure) : base(wysokosc, glebokosc, wagaWlasna, masaladunku, maxLadownosc)
    {
        this.pressure = pressure;
        this.numSer = "KON-G-" + counter++;

    }

    public void Notify(string contId)
    {
        Console.WriteLine("niebezpieczna sytuacja w kontenerze " + contId);
    }

    public override string ToString()
    {
        return base.ToString() + ", " + pressure + "]";
    }

    public override void oproznij()
    {
        masaladunku = 0.05;
    }
}