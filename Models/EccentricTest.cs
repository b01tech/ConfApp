using ConfApp.Models.Enums;
using System.Text;

namespace ConfApp.Models;

public class EccentricTest
{
    TypeEccTest Type { get; set; }
    public double? Mass { get; set; }
    public double? RecordA { get; set; }
    public double? RecordB { get; set; }
    public double? RecordC { get; set; }
    public double? RecordD { get; set; }
    public double? RecordE { get; set; }
    public double? RecordF { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(Type).Append(",");

        if (Mass.HasValue)
        {
            sb.Append(Mass.Value.ToString()).Append(", ");
        }

        if (RecordA.HasValue)
            sb.Append("RecordA: ").Append(RecordA.Value).Append(", ");
        if (RecordB.HasValue)
            sb.Append("RecordB: ").Append(RecordB.Value).Append(", ");
        if (RecordC.HasValue)
            sb.Append("RecordC: ").Append(RecordC.Value).Append(", ");
        if (RecordD.HasValue)
            sb.Append("RecordD: ").Append(RecordD.Value).Append(", ");
        if (RecordE.HasValue)
            sb.Append("RecordE: ").Append(RecordE.Value).Append(", ");
        if (RecordF.HasValue)
            sb.Append("RecordF: ").Append(RecordF.Value);


        return sb.ToString();
    }

}
