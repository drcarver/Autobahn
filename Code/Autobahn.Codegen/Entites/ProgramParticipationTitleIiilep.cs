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
    [Table("ProgramParticipationTitleIIILep", Schema = "Person")]
    public partial class ProgramParticipationTitleIIILep
    {
        public int? RefTitleIIIAccountabilityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTitleIIILanguageInstructionProgramTypeId { get; set; }
        public int PersonProgramParticipationId { get; set; }
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
        public int ProgramParticipationTitleIiiLepId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ProgramParticipationTitleIiileps")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationTitleIiileps")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationTitleIiileps")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefTitleIiiaccountabilityId")]
        [InverseProperty("ProgramParticipationTitleIiileps")]
        public virtual RefTitleIIIAccountability? RefTitleIiiaccountability { get; set; }
        [ForeignKey("RefTitleIiilanguageInstructionProgramTypeId")]
        [InverseProperty("ProgramParticipationTitleIiileps")]
        public virtual RefTitleIIILanguageInstructionProgramType? RefTitleIiilanguageInstructionProgramType { get; set; }
    }
}
