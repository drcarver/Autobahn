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
    [Table("ProgramParticipationCte")]
    [Index("PersonProgramParticipationId", Name = "IX_PersonProgramParticipationId")]
    public partial class ProgramParticipationCte
    {
        public int PersonProgramParticipationId { get; set; }
        public bool? CteParticipant { get; set; }
        public bool? CteConcentrator { get; set; }
        public bool? CteCompleter { get; set; }
        public bool? SingleParentOrSinglePregnantWoman { get; set; }
        public bool? DisplacedHomemakerIndicator { get; set; }
        public bool? CteNonTraditionalCompletion { get; set; }
        public int? RefNonTraditionalGenderStatusId { get; set; }
        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CareerPathwaysProgramParticipationExitDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CareerPathwaysProgramParticipationStartDate { get; set; }
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
        [Key]
        public int ProgramParticipationCteId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? OutOfWorkforceIndicator { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ProgramParticipationCtes")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationCtes")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationCtes")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefNonTraditionalGenderStatusId")]
        [InverseProperty("ProgramParticipationCtes")]
        public virtual RefNonTraditionalGenderStatus? RefNonTraditionalGenderStatus { get; set; }
        [ForeignKey("RefWorkbasedLearningOpportunityTypeId")]
        [InverseProperty("ProgramParticipationCtes")]
        public virtual RefWorkbasedLearningOpportunityType? RefWorkbasedLearningOpportunityType { get; set; }
    }
}
