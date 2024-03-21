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
        _ladunek.Add(kontener); 
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
        kontener.oproznij();
    }

    public void Zastap(Kontener wy, Kontener we)
    {
        Wyjmij(wy);
        Zaladuj(we);
    }

    public void Przenies(Kontenerowiec wy, Kontenerowiec we, Kontener kontener)
    {
        wy.Wyjmij(kontener);
        we.Zaladuj(kontener);
    }
    
    
    
}