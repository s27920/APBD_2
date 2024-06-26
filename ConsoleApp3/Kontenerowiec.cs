using System.Text;

namespace ConsoleApp3;

public class Kontenerowiec
{
    private List<Kontener> _ladunek;
    private int _maxPredkosc;
    private int _maxIloscKont;
    private double _maxladunek;
    private double _ladunekAktualny;

    public Kontenerowiec(int maxPredkosc, int maxIloscKont, double maxladunek)
    {
        _ladunek = new List<Kontener>();
        _maxPredkosc = maxPredkosc;
        _maxIloscKont = maxIloscKont;
        _maxladunek = maxladunek;
        _ladunekAktualny = 0;
    }

    public void Zaladuj(Kontener kontener)
    {
        double nowaWaga = _ladunekAktualny + kontener.Masaladunku + kontener.WagaWlasna;
        if (nowaWaga < _maxladunek*1000)
        {
            _ladunek.Add(kontener);
            _ladunekAktualny = nowaWaga;
        }
    }

    

    public void Wyjmij(Kontener kontener)
    {
        if (_ladunek.Contains(kontener))
        {
            _ladunek.Remove(kontener);
            _ladunekAktualny -= kontener.Masaladunku + kontener.WagaWlasna;
        }
    }

    public void Rozladuj(Kontener kontener)
    {
        kontener.Oproznij();
    }

    public void Zastap(Kontener wy, Kontener we)
    {
        Wyjmij(wy);
        Zaladuj(we);
    }

    public void Przenies(Kontenerowiec wy, Kontenerowiec we, Kontener kontener)
    {
        if (wy._ladunek.Contains(kontener))
        {
            wy.Wyjmij(kontener);
            we.Zaladuj(kontener);
        }
        else
        {
            Console.WriteLine("kontener nie znajduje się w ładowni zadanego statku");
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        int counter = 1;
        foreach (Kontener kontener in _ladunek)
        {
            stringBuilder.Append(counter++).Append(". ").Append(kontener).Append("\n");
        }

        return stringBuilder.ToString();
    }
}