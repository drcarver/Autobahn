//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAcademicRecord.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAcademicRecord
     /// </summary>
    public partial class PsStudentAcademicRecord : IPsStudentAcademicRecord
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.AcademicYearDesignator non nullable property
        /// </summary>
        public System.String AcademicYearDesignator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        public Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.GradePointAverage nullable property
        /// </summary>
        public System.Decimal? GradePointAverage { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.GradePointAverageCumulative nullable property
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.DualCreditDualEnrollmentCredits nullable property
        /// </summary>
        public System.Decimal? DualCreditDualEnrollmentCredits { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.AdvancedPlacementCreditsAwarded nullable property
        /// </summary>
        public System.Int32? AdvancedPlacementCreditsAwarded { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechCredentialType"/> model
        /// </summary>
        public Guid? RefProfessionalTechCredentialTypeId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.EnteringTerm non nullable property
        /// </summary>
        public System.String EnteringTerm { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.CourseTotal nullable property
        /// </summary>
        public System.Int32? CourseTotal { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditHoursAppliedOtherProgram"/> model
        /// </summary>
        public Guid? RefCreditHoursAppliedOtherProgramId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.CreditsAttemptedCumulative nullable property
        /// </summary>
        public System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.CreditsEarnedCumulative nullable property
        /// </summary>
        public System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.NumberOfCreditsAttempted nullable property
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
