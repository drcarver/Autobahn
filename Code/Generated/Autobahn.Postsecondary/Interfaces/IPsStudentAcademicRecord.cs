//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentAcademicRecord.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAcademicRecord Interface
     /// </summary>
    public partial interface IPsStudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.String AcademicYearDesignator { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.Int32? AdvancedPlacementCreditsAwarded { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.Int32? CourseTotal { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.Decimal? DualCreditDualEnrollmentCredits { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.String EnteringTerm { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.Decimal? GradePointAverage { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        Guid? RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        Guid? RefCreditHoursAppliedOtherProgramId { get; set; }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        Guid? RefProfessionalTechCredentialTypeId { get; set; }

    }
}
