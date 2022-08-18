//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationTeacherPrep.cs
//* Name:       Supervised Clinical Experience Clock Hours
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IProgramParticipationTeacherPrep : IAutobahnBase
    {
        /// <summary>
        /// Supervised Clinical Experience Clock Hours
        /// <para>
        /// An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19755">Supervised Clinical Experience Clock Hours</a>
        /// </para>
        /// </summary>
        System.Int32? ClinicalExperienceClockHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAltRouteToCertificationOrLicensure"/> model
        /// </summary>
        Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCriticalTeacherShortageCandidate"/> model
        /// </summary>
        Guid? RefCriticalTeacherShortageCandidateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupervisedClinicalExperience"/> model
        /// </summary>
        Guid? RefSupervisedClinicalExperienceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepCompleterStatus"/> model
        /// </summary>
        Guid? RefTeacherPrepCompleterStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherPrepEnrollmentStatus"/> model
        /// </summary>
        Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// Number of School-age Education Postsecondary Credit Hours
        /// <para>
        /// The number of college course credit hours an individual has successfully completed that are related to K-12 education, parks and recreation, and juvenile justice.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19815">Number of School-age Education Postsecondary Credit Hours</a>
        /// </para>
        /// </summary>
        System.Decimal? SchoolAgeEducationPSCredits { get; set; }

    }
}
