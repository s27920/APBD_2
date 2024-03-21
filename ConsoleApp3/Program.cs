using ConsoleApp3;

public class Program
{
    public static void Main(string[] args)
    {
        Kontenerowiec kontenerowiec = new Kontenerowiec(10, 100, 5000);
        Plynowy k1 = new Plynowy(200, 500, 150, 850, 1300, true);
        Chlodniczy k2 = new Chlodniczy(200, 500, 150, 850, 1300, "banany", 13.2);
        Gazowy k3 = new Gazowy(200, 500, 150, 850, 1300, 1.7);
            
        kontenerowiec.Zaladuj(k1);
        kontenerowiec.Zaladuj(k2);
        kontenerowiec.Zaladuj(k3);
        
        k2.Zaladuj(850);
    }
}
