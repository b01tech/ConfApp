namespace ConfApp.Models;

public class NominalTest
{
    public double  StandardValue { get; set; }
    public double ObservedValue { get; set; }
    public double Error { get; set; }

    public (double StandardValue, ObservedValue, Error) Result { }
}
