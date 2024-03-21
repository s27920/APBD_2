namespace ConsoleApp3;

public abstract class Kontener
{
    protected double wysokosc;
    protected double glebokosc;
    protected double wagaWlasna;
    protected double masaladunku;
    protected string numSer;
    protected double maxLadownosc;

    public double WagaWlasna
    {
        get => wagaWlasna;
        set => wagaWlasna = value;
    }

    public double Masaladunku
    {
        get => masaladunku;
        set => masaladunku = value;
    }

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