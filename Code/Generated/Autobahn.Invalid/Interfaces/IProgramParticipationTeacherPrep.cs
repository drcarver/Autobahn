//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationTeacherPrep.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTeacherPrep Interface
     /// </summary>
    public partial interface IProgramParticipationTeacherPrep : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ClinicalExperienceClockHours { get; set; }

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
         RefAltRouteToCertificationOrLicensureId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCriticalTeacherShortageCandidateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSupervisedClinicalExperienceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTeacherPrepCompleterStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTeacherPrepEnrollmentStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SchoolAgeEducationPSCredits { get; set; }

    }
}
