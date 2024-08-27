namespace ConfApp.Models;

public class IntervalTest
{
    public double MassBefore { get; set; }
    public double  Overload { get; set; }
    public double MassAfter { get; set; }

    public override string ToString()
    {
        return $"{MassBefore},{Overload},{MassAfter}";
    }
}
