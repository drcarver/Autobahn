using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("Facility", Schema = "Facilities")]
    public partial class Facility
    {
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
            FacilityRelationshipFacilities = new HashSet<FacilityRelationship>();
            FacilityRelationshipParentFacilities = new HashSet<FacilityRelationship>();
            FacilitySites = new HashSet<FacilitySite>();
            FacilityUtilizations = new HashSet<FacilityUtilization>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int FacilityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? BuildingName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? BuildingSiteNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefBuildingUseTypeId { get; set; }
        public int? OrganizationId { get; set; }
        [StringLength(100)]
        public string? BuildingArea { get; set; }
        [StringLength(100)]
        public string? BuildingNumberOfStories { get; set; }
        [StringLength(100)]
        public string? BuildingYearBuilt { get; set; }
        [StringLength(100)]
        public string? BuildingYearOfLastModernization { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FacilityAcquisitionDate { get; set; }
        [StringLength(100)]
        public string? FacilityBuildingPermanency { get; set; }
        [StringLength(100)]
        public string? FacilityExpectedLife { get; set; }
        public bool? FacilityOwnershipIndicator { get; set; }
        public int? RefBuildingHistoricStatusId { get; set; }
        public int? RefBuildingPrimaryUseTypeId { get; set; }
        public int? RefCampusStatusId { get; set; }
        public int? RefCampusTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("Facilities")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("Facilities")]
        public virtual Organization? Organization { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Facilities")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingHistoricStatusId")]
        [InverseProperty("Facilities")]
        public virtual RefBuildingHistoricStatus? RefBuildingHistoricStatus { get; set; }
        [ForeignKey("RefBuildingPrimaryUseTypeId")]
        [InverseProperty("Facilities")]
        public virtual RefBuildingPrimaryUseType? RefBuildingPrimaryUseType { get; set; }
        [ForeignKey("RefBuildingUseTypeId")]
        [InverseProperty("Facilities")]
        public virtual RefBuildingUseType? RefBuildingUseType { get; set; }
        [ForeignKey("RefCampusStatusId")]
        [InverseProperty("Facilities")]
        public virtual RefCampusStatus? RefCampusStatus { get; set; }
        [ForeignKey("RefCampusTypeId")]
        [InverseProperty("Facilities")]
        public virtual RefCampusType? RefCampusType { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<BuildingSpace> BuildingSpaces { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<BuildingSystemComponent> BuildingSystemComponents { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityAudit> FacilityAudits { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityDesign> FacilityDesigns { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityEnergy> FacilityEnergies { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityFinance> FacilityFinances { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityHazard> FacilityHazards { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityJointUse> FacilityJointUses { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityLease> FacilityLeases { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityLocation> FacilityLocations { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityManagement> FacilityManagements { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityMandate> FacilityMandates { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityMortgage> FacilityMortgages { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityRelationship> FacilityRelationshipFacilities { get; set; }
        [InverseProperty("ParentFacility")]
        public virtual ICollection<FacilityRelationship> FacilityRelationshipParentFacilities { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilitySite> FacilitySites { get; set; }
        [InverseProperty("Facility")]
        public virtual ICollection<FacilityUtilization> FacilityUtilizations { get; set; }
    }
}
