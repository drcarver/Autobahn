using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityDesign")]
    public partial class FacilityDesign
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityDesign()
        {
            FacilityDesignConstructions = new HashSet<FacilityDesignConstruction>();
            FacilitySchoolDesigns = new HashSet<FacilitySchoolDesign>();
        }

        public int FacilityDesignId { get; set; }

        public int FacilityId { get; set; }

        [StringLength(45)]
        public string BuildingArchitectName { get; set; }

        [StringLength(60)]
        public string BuildingArchitecturalFirmName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BuildingDateOfCertificateOfOccupancy { get; set; }

        public int? RefBuildingDesignTypeId { get; set; }

        public int? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingDesignType RefBuildingDesignType { get; set; }

        public virtual RefBuildingEnvOrEnergyPerformanceRatingCat RefBuildingEnvOrEnergyPerformanceRatingCat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityDesignConstruction> FacilityDesignConstructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilitySchoolDesign> FacilitySchoolDesigns { get; set; }
    }
}
