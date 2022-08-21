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
    [Table("ProgramParticipationSpecialEducation")]
    public partial class ProgramParticipationSpecialEducation
    {
        [Key]
        public int ProgramParticipationSpecialEducationId { get; set; }
        public int PersonProgramParticipationId { get; set; }
        [Column("AwaitingInitialIDEAEvaluationStatus")]
        public bool? AwaitingInitialIdeaevaluationStatus { get; set; }
        [Column("SpecialEducationFTE", TypeName = "decimal(5, 4)")]
        public decimal? SpecialEducationFte { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? SpecialEducationServicesExitDate { get; set; }
        [Column("IDEAPlacementRationale")]
        public string? IdeaplacementRationale { get; set; }
        [Column("RefIDEAEducationalEnvironmentECId")]
        public int? RefIdeaeducationalEnvironmentEcid { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefIDEAEducationalEnvironmentSchoolAgeId")]
        public int? RefIdeaeducationalEnvironmentSchoolAgeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefSpecialEducationExitReasonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ProgramParticipationSpecialEducations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationSpecialEducations")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationSpecialEducations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIdeaeducationalEnvironmentEcid")]
        [InverseProperty("ProgramParticipationSpecialEducations")]
        public virtual RefIdeaeducationalEnvironmentEc? RefIdeaeducationalEnvironmentEc { get; set; }
        [ForeignKey("RefIdeaeducationalEnvironmentSchoolAgeId")]
        [InverseProperty("ProgramParticipationSpecialEducations")]
        public virtual RefIdeaeducationalEnvironmentSchoolAge? RefIdeaeducationalEnvironmentSchoolAge { get; set; }
        [ForeignKey("RefSpecialEducationExitReasonId")]
        [InverseProperty("ProgramParticipationSpecialEducations")]
        public virtual RefSpecialEducationExitReason? RefSpecialEducationExitReason { get; set; }
    }
}
