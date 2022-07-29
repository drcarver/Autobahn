using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityManagementPlan")]
    public partial class FacilityManagementPlan
    {
        public int FacilityManagementPlanId { get; set; }

        public int FacilityManagementId { get; set; }

        [StringLength(80)]
        public string FacilitiesPlanDescription { get; set; }

        public int? RefFacilitiesPlanTypeId { get; set; }

        public int? RefFacilitiesMgmtEmergencyTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual FacilityManagement FacilityManagement { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFacilitiesMgmtEmergencyType RefFacilitiesMgmtEmergencyType { get; set; }

        public virtual RefFacilitiesPlanType RefFacilitiesPlanType { get; set; }
    }
}
