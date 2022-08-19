using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationMigrant")]
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
        public string BirthdateVerification { get; set; }

        public bool? ImmunizationRecordFlag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MigrantStudentQualifyingArrivalDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastQualifyingMoveDate { get; set; }

        [StringLength(30)]
        public string QualifyingMoveFromCity { get; set; }

        public int? RefQualifyingMoveFromStateId { get; set; }

        public int? RefQualifyingMoveFromCountryId { get; set; }

        public int? DesignatedGraduationSchoolId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int ProgramParticipationMigrantId { get; set; }

        public bool? PrioritizedForServices { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefContinuationOfService RefContinuationOfService { get; set; }

        public virtual RefCountry RefCountry { get; set; }

        public virtual RefMepEnrollmentType RefMepEnrollmentType { get; set; }

        public virtual RefMepProjectBased RefMepProjectBased { get; set; }

        public virtual RefMepServiceType RefMepServiceType { get; set; }

        public virtual RefState RefState { get; set; }
    }
}
