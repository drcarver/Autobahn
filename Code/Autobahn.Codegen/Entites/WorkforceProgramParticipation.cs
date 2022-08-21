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
    [Table("WorkforceProgramParticipation")]
    public partial class WorkforceProgramParticipation
    {
        [Key]
        public int WorkforceProgramParticipationId { get; set; }
        public int PersonProgramParticipationId { get; set; }
        [StringLength(7)]
        public string? DiplomaOrCredentialAwardDate { get; set; }
        public int? RefWfProgramParticipationId { get; set; }
        public int? RefProfessionalTechnicalCredentialTypeId { get; set; }
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
        [InverseProperty("WorkforceProgramParticipations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("WorkforceProgramParticipations")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("WorkforceProgramParticipations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefProfessionalTechnicalCredentialTypeId")]
        [InverseProperty("WorkforceProgramParticipations")]
        public virtual RefProfessionalTechnicalCredentialType? RefProfessionalTechnicalCredentialType { get; set; }
        [ForeignKey("RefWfProgramParticipationId")]
        [InverseProperty("WorkforceProgramParticipations")]
        public virtual RefWfProgramParticipation? RefWfProgramParticipation { get; set; }
    }
}
