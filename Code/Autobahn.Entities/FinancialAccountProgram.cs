using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FinancialAccountProgram")]
    public partial class FinancialAccountProgram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinancialAccountProgram()
        {
            OrganizationFinancials = new HashSet<OrganizationFinancial>();
        }

        public int FinancialAccountProgramId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(30)]
        public string ProgramNumber { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationFinancial> OrganizationFinancials { get; set; }
    }
}
