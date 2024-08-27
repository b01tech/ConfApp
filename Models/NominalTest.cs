using System.Text;

namespace ConfApp.Models;

public class NominalTest
{
    public List<(double StandardValue, double ObservedValue, double Error)> Results { get; private set; }

    public NominalTest()
    {
        Results = new();
    }

    public void AddResult(double standardValue, double observedValue)
    {
        var error = standardValue - observedValue;
        Results.Add((standardValue, observedValue, error));
    }

    public override string ToString()
    {
        if (Results.Count == 0)
        {
            return string.Empty;
        }
        var sb = new StringBuilder();
        foreach (var result in Results)
        {
            sb.AppendFormat("({0}, {1}, {2}), ", result.StandardValue, result.ObservedValue, result.Error); ;
        }
        return sb.ToString();
    }

}
