using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("BuildingSystemComponent")]
    public partial class BuildingSystemComponent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildingSystemComponent()
        {
            BuildingSystemCategories = new HashSet<BuildingSystemCategory>();
            BuildingSystemComponentServices = new HashSet<BuildingSystemComponentService>();
            FacilityCompliances = new HashSet<FacilityCompliance>();
        }

        public int BuildingSystemComponentId { get; set; }

        public int FacilityId { get; set; }

        [StringLength(30)]
        public string Identifier { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(4)]
        public string InstallationDate { get; set; }

        public decimal? LifecycleCost { get; set; }

        public int? ComponentOrFixtureUsefulLife { get; set; }

        [StringLength(80)]
        public string BuildingInstitutionalEquipmentDescription { get; set; }

        public int? RefFacilityFurnishingsTypeId { get; set; }

        public int? RefFacilitySystemOrComponentConditionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildingSystemCategory> BuildingSystemCategories { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFacilityFurnishingsType RefFacilityFurnishingsType { get; set; }

        public virtual RefFacilitySystemOrComponentCondition RefFacilitySystemOrComponentCondition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildingSystemComponentService> BuildingSystemComponentServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityCompliance> FacilityCompliances { get; set; }
    }
}
