using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityManagement")]
    public partial class FacilityManagement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityManagement()
        {
            FacilityManagementPlans = new HashSet<FacilityManagementPlan>();
        }

        public int FacilityManagementId { get; set; }

        public int FacilityId { get; set; }

        public int? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

        public int? RefBuildingCleaningStandardTypeId { get; set; }

        public int? RefFacilityCapitalProgramMgmtTypeId { get; set; }

        public int? RefFacilityComplianceAgencyTypeId { get; set; }

        public int? RefFacilityOperationsMgmtTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingCharterSchoolRealtyAccessType RefBuildingCharterSchoolRealtyAccessType { get; set; }

        public virtual RefBuildingCleaningStandardType RefBuildingCleaningStandardType { get; set; }

        public virtual RefFacilityCapitalProgramMgmtType RefFacilityCapitalProgramMgmtType { get; set; }

        public virtual RefFacilityComplianceAgencyType RefFacilityComplianceAgencyType { get; set; }

        public virtual RefFacilityOperationsMgmtType RefFacilityOperationsMgmtType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityManagementPlan> FacilityManagementPlans { get; set; }
    }
}
