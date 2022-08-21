//**********************************************************
//* DomainName: Autobahn.Facility
//* FileName:   FacilityFinancial.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Facility
{
    [Table("Facility", Schema= "Facility")]
    public partial class Facility : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facility()
        {
            BuildingSpaces = new HashSet<BuildingSpace>();
            BuildingSystemComponents = new HashSet<BuildingSystemComponent>();
            FacilityAudits = new HashSet<FacilityAudit>();
            FacilityDesigns = new HashSet<FacilityDesign>();
            FacilityEnergies = new HashSet<FacilityEnergy>();
            FacilityFinances = new HashSet<FacilityFinance>();
            FacilityHazards = new HashSet<FacilityHazard>();
            FacilityJointUses = new HashSet<FacilityJointUse>();
            FacilityLeases = new HashSet<FacilityLease>();
            FacilityLocations = new HashSet<FacilityLocation>();
            FacilityManagements = new HashSet<FacilityManagement>();
            FacilityMandates = new HashSet<FacilityMandate>();
            FacilityMortgages = new HashSet<FacilityMortgage>();
            FacilityRelationships = new HashSet<FacilityRelationship>();
            FacilityRelationships1 = new HashSet<FacilityRelationship>();
            FacilitySites = new HashSet<FacilitySite>();
            FacilityUtilizations = new HashSet<FacilityUtilization>();
        }

        [StringLength(40)]
        public string Identifier { get; set; }

        [StringLength(60)]
        public string BuildingName { get; set; }

        [StringLength(60)]
        public string BuildingSiteNumber { get; set; }

        public Guid? RefBuildingUseTypeId { get; set; }

        public Guid? OrganizationId { get; set; }

        [StringLength(100)]
        public string BuildingArea { get; set; }

        [StringLength(100)]
        public string BuildingNumberOfStories { get; set; }

        [StringLength(100)]
        public string BuildingYearBuilt { get; set; }

        [StringLength(100)]
        public string BuildingYearOfLastModernization { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FacilityAcquisitionDate { get; set; }

        [StringLength(100)]
        public string FacilityBuildingPermanency { get; set; }

        [StringLength(100)]
        public string FacilityExpectedLife { get; set; }

        public bool? FacilityOwnershipIndicator { get; set; }

        public Guid? RefBuildingHistoricStatusId { get; set; }

        public Guid? RefBuildingPrimaryUseTypeId { get; set; }

        public Guid? RefCampusStatusId { get; set; }

        public Guid? RefCampusTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildingSpace> BuildingSpaces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildingSystemComponent> BuildingSystemComponents { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RefBuildingHistoricStatus RefBuildingHistoricStatus { get; set; }

        public virtual RefBuildingPrimaryUseType RefBuildingPrimaryUseType { get; set; }

        public virtual RefBuildingUseType RefBuildingUseType { get; set; }

        public virtual RefCampusStatus RefCampusStatus { get; set; }

        public virtual RefCampusType RefCampusType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityAudit> FacilityAudits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityDesign> FacilityDesigns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityEnergy> FacilityEnergies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityFinance> FacilityFinances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityHazard> FacilityHazards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityJointUse> FacilityJointUses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityLease> FacilityLeases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityLocation> FacilityLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityManagement> FacilityManagements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityMandate> FacilityMandates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityMortgage> FacilityMortgages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityRelationship> FacilityRelationships { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityRelationship> FacilityRelationships1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilitySite> FacilitySites { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityUtilization> FacilityUtilizations { get; set; }
    }
}
