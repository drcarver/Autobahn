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
    [Table("IndividualizedProgramProgressReport", Schema = "Common")]
    public partial class IndividualizedProgramProgressReport
    {
        public IndividualizedProgramProgressReport()
        {
            IndividualizedProgramProgressGoals = new HashSet<IndividualizedProgramProgressGoal>();
        }

        [Key]
        public int IndividualizedProgramProgressReportId { get; set; }
        public int IndividualizedProgramId { get; set; }
        public int IndividualizedProgramProgressReportPlanId { get; set; }
        public string? ProgressDescription { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ProgressReportDate { get; set; }
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
        [InverseProperty("IndividualizedProgramProgressReports")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IndividualizedProgramProgressReports")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("IndividualizedProgramProgressReportPlanId")]
        [InverseProperty("IndividualizedProgramProgressReports")]
        public virtual IndividualizedProgramProgressReportPlan IndividualizedProgramProgressReportPlan { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramProgressReports")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIpspprogressReportTypeId")]
        [InverseProperty("IndividualizedProgramProgressReports")]
        public virtual RefIPSPProgressReportType? RefIpspprogressReportType { get; set; }
        [InverseProperty("IndividualizedProgramProgressReport")]
        public virtual ICollection<IndividualizedProgramProgressGoal> IndividualizedProgramProgressGoals { get; set; }
    }
}
