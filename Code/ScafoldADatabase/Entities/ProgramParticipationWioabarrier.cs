using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("ProgramParticipationWIOABarriers")]
    public partial class ProgramParticipationWioabarrier
    {
        [Key]
        [Column("ProgramParticipationWIOABarriersId")]
        public int ProgramParticipationWioabarriersId { get; set; }
        [Column("ProgramParticipationWIOAId")]
        public int ProgramParticipationWioaid { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefWIOABarrierstoEmploymentId")]
        public int? RefWioabarrierstoEmploymentId { get; set; }
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
        [InverseProperty("ProgramParticipationWioabarriers")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("ProgramParticipationWioaid")]
        [InverseProperty("ProgramParticipationWioabarriers")]
        public virtual ProgramParticipationWioa ProgramParticipationWioa { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationWioabarriers")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefWioabarrierstoEmploymentId")]
        [InverseProperty("ProgramParticipationWioabarriers")]
        public virtual RefWioabarrierstoEmployment? RefWioabarrierstoEmployment { get; set; }
    }
}
