using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentAcademicRecord")]
    public partial class PsStudentAcademicRecord
    {
        public int PsStudentAcademicRecordId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(9)]
        public string AcademicYearDesignator { get; set; }

        public int? RefAcademicTermDesignatorId { get; set; }

        public decimal? GradePointAverage { get; set; }

        public decimal? GradePointAverageCumulative { get; set; }

        public decimal? DualCreditDualEnrollmentCredits { get; set; }

        public int? AdvancedPlacementCreditsAwarded { get; set; }

        public int? RefProfessionalTechCredentialTypeId { get; set; }

        [StringLength(7)]
        public string DiplomaOrCredentialAwardDate { get; set; }

        [StringLength(30)]
        public string EnteringTerm { get; set; }

        public int? CourseTotal { get; set; }

        public int? RefCreditHoursAppliedOtherProgramId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public decimal? CreditsAttemptedCumulative { get; set; }

        public decimal? CreditsEarnedCumulative { get; set; }

        public decimal? NumberOfCreditsAttempted { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAcademicTermDesignator RefAcademicTermDesignator { get; set; }

        public virtual RefCreditHoursAppliedOtherProgram RefCreditHoursAppliedOtherProgram { get; set; }

        public virtual RefProfessionalTechnicalCredentialType RefProfessionalTechnicalCredentialType { get; set; }
    }
}
