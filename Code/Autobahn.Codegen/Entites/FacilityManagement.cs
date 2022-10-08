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
    [Table("FacilityManagement", Schema = "Facilities")]
    public partial class FacilityManagement
    {
        public FacilityManagement()
        {
            FacilityManagementPlans = new HashSet<FacilityManagementPlan>();
        }

        [Key]
        public int FacilityManagementId { get; set; }
        public int FacilityId { get; set; }
        public int? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }
        public int? RefBuildingCleaningStandardTypeId { get; set; }
        public int? RefFacilityCapitalProgramMgmtTypeId { get; set; }
        public int? RefFacilityComplianceAgencyTypeId { get; set; }
        public int? RefFacilityOperationsMgmtTypeId { get; set; }
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
        [InverseProperty("FacilityManagements")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("FacilityManagements")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("FacilityManagements")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingCharterSchoolRealtyAccessTypeId")]
        [InverseProperty("FacilityManagements")]
        public virtual RefBuildingCharterSchoolRealtyAccessType? RefBuildingCharterSchoolRealtyAccessType { get; set; }
        [ForeignKey("RefBuildingCleaningStandardTypeId")]
        [InverseProperty("FacilityManagements")]
        public virtual RefBuildingCleaningStandardType? RefBuildingCleaningStandardType { get; set; }
        [ForeignKey("RefFacilityCapitalProgramMgmtTypeId")]
        [InverseProperty("FacilityManagements")]
        public virtual RefFacilityCapitalProgramMgmtType? RefFacilityCapitalProgramMgmtType { get; set; }
        [ForeignKey("RefFacilityComplianceAgencyTypeId")]
        [InverseProperty("FacilityManagements")]
        public virtual RefFacilityComplianceAgencyType? RefFacilityComplianceAgencyType { get; set; }
        [ForeignKey("RefFacilityOperationsMgmtTypeId")]
        [InverseProperty("FacilityManagements")]
        public virtual RefFacilityOperationsMgmtType? RefFacilityOperationsMgmtType { get; set; }
        [InverseProperty("FacilityManagement")]
        public virtual ICollection<FacilityManagementPlan> FacilityManagementPlans { get; set; }
    }
}
