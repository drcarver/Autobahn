using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("ProgramParticipationWIOABarriers", Schema = "Person")]
    public partial class ProgramParticipationWIOABarriers
    {
        [Key]
        public int ProgramParticipationWIOABarriersId { get; set; }
        public int ProgramParticipationWIOAId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefWIOABarrierstoEmploymentId { get; set; }
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
        public virtual ProgramParticipationWIOA ProgramParticipationWioa { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationWioabarriers")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefWioabarrierstoEmploymentId")]
        [InverseProperty("ProgramParticipationWioabarriers")]
        public virtual RefWIOABarrierstoEmployment? RefWioabarrierstoEmployment { get; set; }
    }
}
