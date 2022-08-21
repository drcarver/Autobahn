//**********************************************************
//* DomainName: Autobahn.Facility
//* FileName:   FacilityMortgage.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Interfaces.Facility;

namespace Autobahn.Entities.Facility
{
    [Table("FacilityMortgage", Schema= "Facility")]
    public partial class FacilityMortgage : EntityBase, IFacilityMortgage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityMortgage()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
            FacilityMortgageFees = new HashSet<FacilityMortgageFee>();
        }

        [ForeignKey("Facility")]
        public Guid FacilityId { get; set; }

        public decimal? FacilityMortgageInterestAmount { get; set; }

        public decimal? FacilityTotalAssessedValue { get; set; }

        [ForeignKey("RefFacilityMortgageInterestType")]
        public Guid? RefFacilityMortgageInterestTypeId { get; set; }

        [ForeignKey("RefFacilityMortgageType")]
        public Guid? RefFacilityMortgageTypeId { get; set; }

        public virtual Facility Facility { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }

        public virtual RefFacilityMortgageInterestType RefFacilityMortgageInterestType { get; set; }

        public virtual RefFacilityMortgageType RefFacilityMortgageType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityMortgageFee> FacilityMortgageFees { get; set; }
    }
}
