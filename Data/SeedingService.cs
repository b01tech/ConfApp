using ConfApp.Models;

namespace ConfApp.Data;

public class SeedingService
{
    private readonly AppDbContext _context;

    public SeedingService(AppDbContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        if (_context.Calibrations.Any() || _context.Weights.Any() || _context.Customers.Any() || _context.Scales.Any())
        {
            return;
        }

        var s1 = new Scale { Capacity = 1000.0, Model = "Teste", ResolutionD = 0.01, ResolutionE = 0.01, ScaleClass = (Models.Enums.ScaleClass)1, SerialNo = "NS123", ScaleId = 1, TagName = "BALTEST", Unit = (Models.Enums.Unit)1 };

        var x1 = new Customer { CustomerId = 1, Name = "Cliente Teste", Address = "Rua 123", City = "Curitiba", State = "PR" };

        var w1 = new Weight { WeightId = 1, Tag = "MP-TESTE001", NominalMass = 500.00 };
        var w2 = new Weight { WeightId = 2, Tag = "MP-TESTE002", NominalMass = 100.00 };
        var w3 = new Weight { WeightId = 3, Tag = "MP-TESTE003", NominalMass = 50.00 };

        var c1 = new Calibration
        {
            CalibrationId = 1,
            Place = "Local Teste",
            Manager = "Gerente",
            Technician = "Técnico",
            PointCal = 500.00,
            DateCal = new DateTime(2000, 10, 01),
            DateReport = DateTime.Now,
            EccentricTest = "NA",
            IntervalTest = "100.0,1.0,101.0",
            Scale = s1,
            Status = Models.Enums.StatusReport.Aprovado,
            Tag = "10000-1",
            Customer = x1,
            NominalTest = "(100,100,0),(200,200,0),(500,500,0)",
            Weights = new List<Weight> { w1, w2, w3 },
        };

        _context.Scales.Add(s1);
        _context.Customers.Add(x1);
        _context.Weights.AddRange(w1,w2,w3);
        _context.Calibrations.Add(c1);
        _context.SaveChanges();

    }
}