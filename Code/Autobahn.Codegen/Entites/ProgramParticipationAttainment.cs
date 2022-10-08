using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("ProgramParticipationAttainment", Schema = "AdultEducation")]
    public partial class ProgramParticipationAttainment
    {
        [Key]
        public int ProgramParticipationAttainmentId { get; set; }
        public int PersonProgramParticipationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("AECredentialAttainmentEmployedIndicator")]
        public bool? AecredentialAttainmentEmployedIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("AECredentialAttainmentPSCredentialIndicator")]
        public bool? AecredentialAttainmentPscredentialIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("AECredentialAttainmentPSEnrollmentIndicator")]
        public bool? AecredentialAttainmentPsenrollmentIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }
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
        [InverseProperty("ProgramParticipationAttainments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationAttainments")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationAttainments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId")]
        [InverseProperty("ProgramParticipationAttainments")]
        public virtual RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType { get; set; }
        [ForeignKey("RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId")]
        [InverseProperty("ProgramParticipationAttainments")]
        public virtual RefEdFactsAcademicOrCareerAndTechnicalOutcomeType? RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { get; set; }
    }
}
