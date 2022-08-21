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
    [Table("ProgramParticipationFoodService")]
    public partial class ProgramParticipationFoodService
    {
        [Key]
        public int ProgramParticipationFoodServiceId { get; set; }
        public int PersonProgramParticipationId { get; set; }
        public int RefSchoolFoodServiceProgramId { get; set; }
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
        [InverseProperty("ProgramParticipationFoodServices")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationFoodServices")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationFoodServices")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefSchoolFoodServiceProgramId")]
        [InverseProperty("ProgramParticipationFoodServices")]
        public virtual RefSchoolFoodServiceProgram RefSchoolFoodServiceProgram { get; set; } = null!;
    }
}
