using ConfApp.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ConfApp.Models;

public class Calibration
{
    [Key]
    public int CalibrationId { get; set; }
    [Required]
    public string Tag  { get; set; }
    [Required]
    public Customer Customer { get; set; }
    [Required]
    public Scale Scale { get; set; }
    [StringLength(100)]
    public string Place  { get; set; }
    public double PointCal { get; set; }
    public string EccentricTest { get; set; }
    public string IntervalTest { get; set; }
    public string NominalTest { get; set; }
    public List<Weight> Weights { get; set; } = new();
    [DataType(DataType.Date)]
    public DateTime DateCal { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime DateReport { get; set; }
    [Required]
    public string Technician { get; set; }
    [Required]
    public string  Manager { get; set; }
    public StatusReport Status { get; set; }
}
