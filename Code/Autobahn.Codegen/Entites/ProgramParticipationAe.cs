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
    [Table("ProgramParticipationAE", Schema = "AdultEducation")]
    public partial class ProgramParticipationAE
    {
        [Key]
        public int ProgramParticipationAEId { get; set; }
        public int PersonProgramParticipationId { get; set; }
        public int? RefAeInstructionalProgramTypeId { get; set; }
        public int? RefAePostsecondaryTransitionActionId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PostsecondaryTransitionDate { get; set; }
        public int? RefAeSpecialProgramTypeId { get; set; }
        public int? RefAeFunctioningLevelAtIntakeId { get; set; }
        public int? RefAeFunctioningLevelAtPosttestId { get; set; }
        public int? RefGoalsForAttendingAdultEducationId { get; set; }
        public bool? DisplacedHomemakerIndicator { get; set; }
        [Column(TypeName = "decimal(5, 1)")]
        public decimal? ProxyContactHours { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? InstructionalActivityHoursCompleted { get; set; }
        public int? RefCorrectionalEducationFacilityTypeId { get; set; }
        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? OutOfWorkforceIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdultEducationProgramExitReasonId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAdultEducationProgramExitReasonId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RefAdultEducationProgramExitReason? RefAdultEducationProgramExitReason { get; set; }
        [ForeignKey("RefAeFunctioningLevelAtIntakeId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RefAEFunctioningLevelAtIntake? RefAeFunctioningLevelAtIntake { get; set; }
        [ForeignKey("RefAeFunctioningLevelAtPosttestId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RefAEFunctioningLevelAtPosttest? RefAeFunctioningLevelAtPosttest { get; set; }
        [ForeignKey("RefAeInstructionalProgramTypeId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RefAeInstructionalProgramType? RefAeInstructionalProgramType { get; set; }
        [ForeignKey("RefAePostsecondaryTransitionActionId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RefAePostsecondaryTransitionAction? RefAePostsecondaryTransitionAction { get; set; }
        [ForeignKey("RefAeSpecialProgramTypeId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RefAeSpecialProgramType? RefAeSpecialProgramType { get; set; }
        [ForeignKey("RefCorrectionalEducationFacilityTypeId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RefCorrectionalEducationFacilityType? RefCorrectionalEducationFacilityType { get; set; }
        [ForeignKey("RefGoalsForAttendingAdultEducationId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RefGoalsForAttendingAdultEducation? RefGoalsForAttendingAdultEducation { get; set; }
        [ForeignKey("RefWorkbasedLearningOpportunityTypeId")]
        [InverseProperty("ProgramParticipationAes")]
        public virtual RefWorkbasedLearningOpportunityType? RefWorkbasedLearningOpportunityType { get; set; }
    }
}
