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
    [Table("PersonProgramParticipation")]
    [Index("OrganizationPersonRoleId", Name = "IX_OrganizationPersonRoleId")]
    public partial class PersonProgramParticipation
    {
        public PersonProgramParticipation()
        {
            ProgramParticipationAes = new HashSet<ProgramParticipationAe>();
            ProgramParticipationAttainments = new HashSet<ProgramParticipationAttainment>();
            ProgramParticipationCtes = new HashSet<ProgramParticipationCte>();
            ProgramParticipationFoodServices = new HashSet<ProgramParticipationFoodService>();
            ProgramParticipationMigrants = new HashSet<ProgramParticipationMigrant>();
            ProgramParticipationNeglecteds = new HashSet<ProgramParticipationNeglected>();
            ProgramParticipationSpecialEducations = new HashSet<ProgramParticipationSpecialEducation>();
            ProgramParticipationTeacherPreps = new HashSet<ProgramParticipationTeacherPrep>();
            ProgramParticipationTitleIiileps = new HashSet<ProgramParticipationTitleIiilep>();
            ProgramParticipationTitleIs = new HashSet<ProgramParticipationTitleI>();
            ProgramParticipationWioas = new HashSet<ProgramParticipationWioa>();
            WorkforceProgramParticipations = new HashSet<WorkforceProgramParticipation>();
        }

        public int OrganizationPersonRoleId { get; set; }
        public int? RefParticipationTypeId { get; set; }
        public int? RefProgramExitReasonId { get; set; }
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
        public int PersonProgramParticipationId { get; set; }
        [StringLength(100)]
        public string? ParticipationStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProgramEntryReasonId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PersonProgramParticipations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("PersonProgramParticipations")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonProgramParticipations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefParticipationTypeId")]
        [InverseProperty("PersonProgramParticipations")]
        public virtual RefParticipationType? RefParticipationType { get; set; }
        [ForeignKey("RefProgramEntryReasonId")]
        [InverseProperty("PersonProgramParticipations")]
        public virtual RefProgramEntryReason? RefProgramEntryReason { get; set; }
        [ForeignKey("RefProgramExitReasonId")]
        [InverseProperty("PersonProgramParticipations")]
        public virtual RefProgramExitReason? RefProgramExitReason { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationAe> ProgramParticipationAes { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationAttainment> ProgramParticipationAttainments { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationCte> ProgramParticipationCtes { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationFoodService> ProgramParticipationFoodServices { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationMigrant> ProgramParticipationMigrants { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationNeglected> ProgramParticipationNeglecteds { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationSpecialEducation> ProgramParticipationSpecialEducations { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationTeacherPrep> ProgramParticipationTeacherPreps { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationTitleIiilep> ProgramParticipationTitleIiileps { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationTitleI> ProgramParticipationTitleIs { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<ProgramParticipationWioa> ProgramParticipationWioas { get; set; }
        [InverseProperty("PersonProgramParticipation")]
        public virtual ICollection<WorkforceProgramParticipation> WorkforceProgramParticipations { get; set; }
    }
}
