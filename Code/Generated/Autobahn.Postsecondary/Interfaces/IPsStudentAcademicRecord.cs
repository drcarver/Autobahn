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
        /// 
        /// </summary>
         AcademicYearDesignator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? AdvancedPlacementCreditsAwarded { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CourseTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DualCreditDualEnrollmentCredits { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EnteringTerm { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GradePointAverage { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GradePointAverageCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCreditHoursAppliedOtherProgramId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProfessionalTechCredentialTypeId { get; set; }

    }
}
