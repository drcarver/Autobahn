using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("_CEDSElements")]
    public partial class C_CEDSElements
    {
        [StringLength(20)]
        public string GlobalID { get; set; }

        [Required]
        [StringLength(150)]
        public string ElementName { get; set; }

        [StringLength(150)]
        public string AltName { get; set; }

        [Required]
        public string Definition { get; set; }

        [StringLength(150)]
        public string Format { get; set; }

        public bool HasOptionSet { get; set; }

        public string UsageNotes { get; set; }

        [StringLength(512)]
        public string URL { get; set; }

        [StringLength(20)]
        public string Version { get; set; }

        [Key]
        public int TermID { get; set; }

        [StringLength(20)]
        public string ChangedInThisVersionInd { get; set; }

        public string ChangeNotes { get; set; }
    }
}
