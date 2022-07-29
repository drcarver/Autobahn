using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityEnergy")]
    public partial class FacilityEnergy
    {
        public int FacilityEnergyId { get; set; }

        public int FacilityId { get; set; }

        [StringLength(60)]
        public string BuildingEnergyServiceCompanyName { get; set; }

        public int? RefBuildingEnergySourceTypeId { get; set; }

        public int? RefFacilityUtilityProviderTypeId { get; set; }

        public int? RefFacilityUtilityTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingEnergySourceType RefBuildingEnergySourceType { get; set; }

        public virtual RefFacilityUtilityProviderType RefFacilityUtilityProviderType { get; set; }

        public virtual RefFacilityUtilityType RefFacilityUtilityType { get; set; }
    }
}
