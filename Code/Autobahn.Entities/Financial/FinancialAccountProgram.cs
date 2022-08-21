//**********************************************************
//* DomainName: Autobahn.Financial
//* FileName:   FinancialAccountProgram.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Interfaces.Financial;

namespace Autobahn.Entities.Financial
{
    [Table("FinancialAccountProgram", Schema= "Financial")]
    public partial class FinancialAccountProgram : EntityBase, IFinancialAccountProgram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinancialAccountProgram()
        {
            OrganizationFinancials = new HashSet<OrganizationFinancial>();
        }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(30)]
        public string ProgramNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationFinancial> OrganizationFinancials { get; set; }
    }
}
