//**********************************************************
//* DomainName: Autobahn.Facility
//* FileName:   FacilityLease.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Facility
{
    [Table("FacilityLease", Schema = "Facility")]
    public partial class FacilityLease : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityLease()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
        }

        [ForeignKey("Facility")]
        public Guid FacilityId { get; set; }

        public decimal? FacilityLeaseAmount { get; set; }

        [ForeignKey("RefFacilityLeaseAmountCategory")]
        public Guid? RefFacilityLeaseAmountCategoryId { get; set; }

        [ForeignKey("RefFacilityLeaseType")]
        public Guid? RefFacilityLeaseTypeId { get; set; }

        public virtual Facility Facility { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }

        public virtual RefFacilityLeaseAmountCategory RefFacilityLeaseAmountCategory { get; set; }

        public virtual RefFacilityLeaseType RefFacilityLeaseType { get; set; }
    }
}
