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
    [Table("IndividualizedProgramProgressReportPlan", Schema = "Common")]
    public partial class IndividualizedProgramProgressReportPlan
    {
        public IndividualizedProgramProgressReportPlan()
        {
            IndividualizedProgramProgressReports = new HashSet<IndividualizedProgramProgressReport>();
        }

        [Key]
        public int IndividualizedProgramProgressReportPlanId { get; set; }
        public int IndividualizedProgramId { get; set; }
        public int? RefIPSPProgressReportScheduleId { get; set; }
        public int? RefIPSPProgressReportTypeId { get; set; }
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
        [InverseProperty("IndividualizedProgramProgressReportPlans")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IndividualizedProgramProgressReportPlans")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramProgressReportPlans")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIpspprogressReportScheduleId")]
        [InverseProperty("IndividualizedProgramProgressReportPlans")]
        public virtual RefIPSPProgressReportType? RefIpspprogressReportSchedule { get; set; }
        [ForeignKey("RefIpspprogressReportTypeId")]
        [InverseProperty("IndividualizedProgramProgressReportPlans")]
        public virtual RefIPSPProgressReportType? RefIpspprogressReportType { get; set; }
        [InverseProperty("IndividualizedProgramProgressReportPlan")]
        public virtual ICollection<IndividualizedProgramProgressReport> IndividualizedProgramProgressReports { get; set; }
    }
}
