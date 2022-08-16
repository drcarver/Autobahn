//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationMigrant.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationMigrant Interface
     /// </summary>
    public partial interface IProgramParticipationMigrant : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         BirthdateVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ContinuationOfServicesStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DesignatedGraduationSchoolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ImmunizationRecordFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? LastQualifyingMoveDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MepEligibilityExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MigrantStudentQualifyingArrivalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PrioritizedForServices { get; set; }

        /// <summary>
        /// 
        /// </summary>
         QualifyingMoveFromCity { get; set; }

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
         RefContinuationOfServicesReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMepEnrollmentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMepProjectBasedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMepServiceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefQualifyingMoveFromCountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefQualifyingMoveFromStateId { get; set; }

    }
}
