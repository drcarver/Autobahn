using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Common;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationMigrant")]
    public partial class ProgramParticipationMigrant : EntityReferenceBase
    {
        public Guid? RefMepEnrollmentTypeId { get; set; }

        public Guid? RefMepProjectBasedId { get; set; }

        public Guid? RefMepServiceTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MepEligibilityExpirationDate { get; set; }

        public bool? ContinuationOfServicesStatus { get; set; }

        public Guid? RefContinuationOfServicesReasonId { get; set; }

        [StringLength(60)]
        public string BirthdateVerification { get; set; }

        public bool? ImmunizationRecordFlag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MigrantStudentQualifyingArrivalDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastQualifyingMoveDate { get; set; }

        [StringLength(30)]
        public string QualifyingMoveFromCity { get; set; }

        public Guid? RefQualifyingMoveFromStateId { get; set; }

        public Guid? RefQualifyingMoveFromCountryId { get; set; }

        public Guid? DesignatedGraduationSchoolId { get; set; }

        public int ProgramParticipationMigrantId { get; set; }

        public bool? PrioritizedForServices { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RefContinuationOfService RefContinuationOfService { get; set; }

        public virtual RefCountry RefCountry { get; set; }

        public virtual RefMepEnrollmentType RefMepEnrollmentType { get; set; }

        public virtual RefMepProjectBased RefMepProjectBased { get; set; }

        public virtual RefMepServiceType RefMepServiceType { get; set; }

        public virtual RefState RefState { get; set; }
    }
}
