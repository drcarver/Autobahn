using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationTeacherPrep")]
    public partial class ProgramParticipationTeacherPrep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProgramParticipationTeacherPrep()
        {
            TeacherEducationCredentialExams = new HashSet<TeacherEducationCredentialExam>();
        }

        public int? RefTeacherPrepEnrollmentStatusId { get; set; }

        public int? RefTeacherPrepCompleterStatusId { get; set; }

        public int? RefSupervisedClinicalExperienceId { get; set; }

        public int? ClinicalExperienceClockHours { get; set; }

        public int? RefTeachingCredentialBasisId { get; set; }

        public int? RefTeachingCredentialTypeId { get; set; }

        public int? RefCriticalTeacherShortageCandidateId { get; set; }

        public int? RefAltRouteToCertificationOrLicensureId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int PersonProgramParticipationId { get; set; }

        public int ProgramParticipationTeacherPrepId { get; set; }

        public decimal? SchoolAgeEducationPSCredits { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RefCriticalTeacherShortageCandidate RefCriticalTeacherShortageCandidate { get; set; }

        public virtual RefTeacherPrepCompleterStatus RefTeacherPrepCompleterStatus { get; set; }

        public virtual RefTeacherPrepEnrollmentStatus RefTeacherPrepEnrollmentStatus { get; set; }

        public virtual RefTeachingCredentialBasi RefTeachingCredentialBasi { get; set; }

        public virtual RefTeachingCredentialType RefTeachingCredentialType { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAltRouteToCertificationOrLicensure RefAltRouteToCertificationOrLicensure { get; set; }

        public virtual RefSupervisedClinicalExperience RefSupervisedClinicalExperience { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherEducationCredentialExam> TeacherEducationCredentialExams { get; set; }
    }
}
