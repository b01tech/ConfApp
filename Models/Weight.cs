using System.ComponentModel.DataAnnotations;

namespace ConfApp.Models;

public class Weight
{
    [Key]
    public int WeightId { get; set; }
    public string Tag { get; set; }
    public double NominalMass { get; set; }

    public Weight()
    {
        
    }

}
