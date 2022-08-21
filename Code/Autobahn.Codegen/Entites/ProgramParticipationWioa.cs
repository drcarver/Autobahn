using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("ProgramParticipationWIOA")]
    public partial class ProgramParticipationWioa
    {
        public ProgramParticipationWioa()
        {
            ProgramParticipationWioabarriers = new HashSet<ProgramParticipationWioabarrier>();
        }

        [Key]
        [Column("ProgramParticipationWIOAId")]
        public int ProgramParticipationWioaid { get; set; }
        public int PersonProgramParticipationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("WIOACareerServices")]
        public bool? WioacareerServices { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("WIOATrainingServices")]
        public bool? WioatrainingServices { get; set; }
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
        [InverseProperty("ProgramParticipationWioas")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationWioas")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationWioas")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("ProgramParticipationWioa")]
        public virtual ICollection<ProgramParticipationWioabarrier> ProgramParticipationWioabarriers { get; set; }
    }
}
