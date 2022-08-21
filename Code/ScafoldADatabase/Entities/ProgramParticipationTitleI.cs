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
    [Table("ProgramParticipationTitleI")]
    public partial class ProgramParticipationTitleI
    {
        [Key]
        [Column("ProgramParticipationTitleIId")]
        public int ProgramParticipationTitleIid { get; set; }
        public int PersonProgramParticipationId { get; set; }
        [Column("RefTitleIIndicatorId")]
        public int? RefTitleIindicatorId { get; set; }
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
        [InverseProperty("ProgramParticipationTitleIs")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationTitleIs")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationTitleIs")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefTitleIindicatorId")]
        [InverseProperty("ProgramParticipationTitleIs")]
        public virtual RefTitleIindicator? RefTitleIindicator { get; set; }
    }
}
