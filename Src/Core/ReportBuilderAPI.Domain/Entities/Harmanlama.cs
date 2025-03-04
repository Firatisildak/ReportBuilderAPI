using ReportBuilderAPI.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportBuilderAPI.Domain.Entities;

[Table("std_tbl_rapor_harmanlama")]
public class Harmanlama : BaseEntity
{
    public DateTime dt { get; set; }
    public int parti_id { get; set; }
    public int batch_no { get; set; }
    public int tn { get; set; }
    public int adim_no { get; set; }

    [ForeignKey("Hammadde")]
    public int hmmd_id { get; set; }

    [ForeignKey("Recete")]
    public int recete_id { get; set; }

    public int alinacak { get; set; }
    public int alinan { get; set; }
    public int shut { get; set; }
    public int silo_no { get; set; }
    public int SUMCHECK { get; set; }
    public int COUNTER { get; set; }

    public required Recete Recete { get; set; }
    public Hammadde Hammadde { get; set; }
}

