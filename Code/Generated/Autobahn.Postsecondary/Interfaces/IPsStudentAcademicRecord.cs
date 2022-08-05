//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentAcademicRecord.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAcademicRecord
     /// </summary>
    public partial interface IPsStudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.AcademicYearDesignator non nullable property
        /// </summary>
        System.String AcademicYearDesignator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicTermDesignator"/> model
        /// </summary>
        Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.GradePointAverage nullable property
        /// </summary>
        System.Decimal? GradePointAverage { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.GradePointAverageCumulative nullable property
        /// </summary>
        System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.DualCreditDualEnrollmentCredits nullable property
        /// </summary>
        System.Decimal? DualCreditDualEnrollmentCredits { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.AdvancedPlacementCreditsAwarded nullable property
        /// </summary>
        System.Int32? AdvancedPlacementCreditsAwarded { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechCredentialType"/> model
        /// </summary>
        Guid? RefProfessionalTechCredentialTypeId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.EnteringTerm non nullable property
        /// </summary>
        System.String EnteringTerm { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.CourseTotal nullable property
        /// </summary>
        System.Int32? CourseTotal { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditHoursAppliedOtherProgram"/> model
        /// </summary>
        Guid? RefCreditHoursAppliedOtherProgramId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.CreditsAttemptedCumulative nullable property
        /// </summary>
        System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.CreditsEarnedCumulative nullable property
        /// </summary>
        System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicRecord.NumberOfCreditsAttempted nullable property
        /// </summary>
        System.Decimal? NumberOfCreditsAttempted { get; set; }

    }
}
