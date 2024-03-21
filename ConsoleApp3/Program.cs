namespace ConsoleApp3;

public class Program
{
    public static void Main(string[] args)
    {
        Kontenerowiec kontenerowiec = new Kontenerowiec(10, 100, 5000);
        Plynowy k1 = new Plynowy(200, 500, 150, 850, 1300, true);
        Chlodniczy k2 = new Chlodniczy(400, 800, 300, 850, 1300, "banany", 13.2);
        Gazowy k3 = new Gazowy(300, 700, 250, 850, 1300, 1.7);
            
        kontenerowiec.Zaladuj(k1);
        kontenerowiec.Zaladuj(k2);
        kontenerowiec.Zaladuj(k3);
        
        Console.WriteLine(k2.ToString());
        k2.Zaladuj(850);
        Console.WriteLine(k2.ToString());
        k2.Oproznij();
        Console.WriteLine(k2.ToString());

        Console.WriteLine(kontenerowiec.ToString());
        kontenerowiec.Wyjmij(k2);
        Console.WriteLine("\n"+kontenerowiec);

        k2.Temp = 14;
        
        Kontenerowiec kontenerowiec2 = new Kontenerowiec(20, 200, 10000);
        Console.WriteLine("\nprzed");
        Console.WriteLine("kontenerowiec 1 \n"+kontenerowiec);
        Console.WriteLine("kontenerowiec 2 "+kontenerowiec2);
        kontenerowiec.Przenies(kontenerowiec, kontenerowiec2, k1);
        kontenerowiec.Przenies(kontenerowiec, kontenerowiec2, k1);
        Console.WriteLine("\npo");
        Console.WriteLine("kontenerowiec 1 \n"+ kontenerowiec);
        Console.WriteLine("kontenerowiec 2 \n"+ kontenerowiec2);
        
        kontenerowiec2.Zastap(k1,k3);
        Console.WriteLine("kontenerowiec 2 \n"+ kontenerowiec2);
        
    }
}