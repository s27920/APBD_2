namespace ConsoleApp3;

public abstract class Kontener
{
    protected double Wysokosc;
    protected double Glebokosc;
    protected double wagaWlasna;
    protected double masaladunku;
    protected string NumSer;
    protected double MaxLadownosc;
    public static int Counter = 0;

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

    

    protected Kontener(double wysokosc, double glebokosc, double wagaWlasna, double masaladunku, double maxLadownosc)
    {
        this.Wysokosc = wysokosc;
        this.Glebokosc = glebokosc;
        this.wagaWlasna = wagaWlasna;
        this.masaladunku = masaladunku;
        this.MaxLadownosc = maxLadownosc;
    }
    public virtual void Oproznij()
    {
        masaladunku = 0;
    }
    
    public virtual void Zaladuj(double waga)
    {
        try
        {
            double nowy = masaladunku + waga;
            if (nowy > this.MaxLadownosc)
            {
                masaladunku = MaxLadownosc;
                throw new OverFillException("zbyt duży ładunek, odrzucono " + (nowy - MaxLadownosc) + "kg ładunku");
            }
                masaladunku += waga; 
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
       
    }
    public override string ToString()
    {
        return "[" + Wysokosc +", " + Glebokosc + ", " + wagaWlasna + ", " + masaladunku + ", " + MaxLadownosc;
    }
    
}