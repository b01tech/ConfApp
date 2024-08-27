using ConfApp.Models.Enums;

namespace ConfApp.Models;

public class Scale
{
    public string  TagName { get; set; }
    public string  Model { get; set; }
    public string  SerialNo { get; set; }
    public ScaleClass ScaleClass { get; set; }
    public double Capacity { get; set; }
    public double ResolutionD { get; set; }
    public double  ResolutionE { get; set; }
    public Unit Unit { get; set; }
}
