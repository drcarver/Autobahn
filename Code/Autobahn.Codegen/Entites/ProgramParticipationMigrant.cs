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
    [Table("ProgramParticipationMigrant", Schema = "K12")]
    public partial class ProgramParticipationMigrant
    {
        public int PersonProgramParticipationId { get; set; }
        public int? RefMepEnrollmentTypeId { get; set; }
        public int? RefMepProjectBasedId { get; set; }
        public int? RefMepServiceTypeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? MepEligibilityExpirationDate { get; set; }
        public bool? ContinuationOfServicesStatus { get; set; }
        public int? RefContinuationOfServicesReasonId { get; set; }
        [StringLength(60)]
        public string? BirthdateVerification { get; set; }
        public bool? ImmunizationRecordFlag { get; set; }
        [Column(TypeName = "date")]
        public DateTime? MigrantStudentQualifyingArrivalDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LastQualifyingMoveDate { get; set; }
        [StringLength(30)]
        public string? QualifyingMoveFromCity { get; set; }
        public int? RefQualifyingMoveFromStateId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefQualifyingMoveFromCountryId { get; set; }
        public int? DesignatedGraduationSchoolId { get; set; }
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
        public int ProgramParticipationMigrantId { get; set; }
        public bool? PrioritizedForServices { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("DesignatedGraduationSchoolId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual Organization? DesignatedGraduationSchool { get; set; }
        [ForeignKey("PersonProgramParticipationId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefContinuationOfServicesReasonId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual RefContinuationOfService? RefContinuationOfServicesReason { get; set; }
        [ForeignKey("RefMepEnrollmentTypeId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual RefMepEnrollmentType? RefMepEnrollmentType { get; set; }
        [ForeignKey("RefMepProjectBasedId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual RefMepProjectBased? RefMepProjectBased { get; set; }
        [ForeignKey("RefMepServiceTypeId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual RefMepServiceType? RefMepServiceType { get; set; }
        [ForeignKey("RefQualifyingMoveFromCountryId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual RefCountry? RefQualifyingMoveFromCountry { get; set; }
        [ForeignKey("RefQualifyingMoveFromStateId")]
        [InverseProperty("ProgramParticipationMigrants")]
        public virtual RefState? RefQualifyingMoveFromState { get; set; }
    }
}
