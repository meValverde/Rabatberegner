namespace Uge1;

public class Rabatberegner
{
    public double GetPrisEfterRabat(int antalVarer, double stykPris)
    {
        var bruttoPris = antalVarer * stykPris;
        var rabat = 0.0;
        
        if (bruttoPris > 1000)
        {
            // Indkøb over 1000 kr. giver 3% rabat
            rabat = rabat + 0.03;
        }

        if (antalVarer > 10)
        {
            // Flere end 10 varer giver 2% rabat
            rabat = rabat + 0.02;
        }

        bruttoPris = bruttoPris - (bruttoPris * rabat);
        return bruttoPris;
    }
}