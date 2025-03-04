using ReportBuilderAPI.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportBuilderAPI.Domain.Entities
{
    [Table("std_tbl_hmmd")]
    public class Hammadde : BaseEntity
    {
        public string hmmd_adi {  get; set; }
        public string hmmd_kodu {  get; set; }
        public ICollection<Harmanlama> Harmanlamalar { get; set; }
    }
}
