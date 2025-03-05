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
    public int silo_no { get; set; }

    public required Recete Recete { get; set; }
    public Hammadde Hammadde { get; set; }
}

//Select recete_id, alinacak, alinan From std_tbl_rapor_harmanlama WHERE
//std_tbl_rapor_harmanlama.dt >= '2/25/2025 4:03:09'
//AND
//std_tbl_rapor_harmanlama.dt <= '3/5/2025 4:03:09'