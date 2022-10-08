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
    [Table("ProgramParticipationNeglected", Schema = "Person")]
    public partial class ProgramParticipationNeglected
    {
        public int PersonProgramParticipationId { get; set; }
        public int? RefNeglectedProgramTypeId { get; set; }
        public bool? AchievementIndicator { get; set; }
        public bool? OutcomeIndicator { get; set; }
        public bool? ObtainedEmployment { get; set; }
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
        public int ProgramParticipationNeglectedId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ProgramParticipationNeglecteds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationNeglecteds")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationNeglecteds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefNeglectedProgramTypeId")]
        [InverseProperty("ProgramParticipationNeglecteds")]
        public virtual RefNeglectedProgramType? RefNeglectedProgramType { get; set; }
    }
}
