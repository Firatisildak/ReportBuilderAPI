using ReportBuilderAPI.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportBuilderAPI.Domain.Entities;

[Table("std_tbl_recete")]
public class Recete : BaseEntity
{
    public string recete_adi { get; set; }

    public int recete_kodu { get; set; }

    public int recete_revno { get; set; }

    public ICollection<Harmanlama> Harmanlamalar { get; set; }
}
