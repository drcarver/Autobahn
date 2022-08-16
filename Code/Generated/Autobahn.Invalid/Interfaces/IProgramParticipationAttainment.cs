//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationAttainment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationAttainment Interface
     /// </summary>
    public partial interface IProgramParticipationAttainment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AECredentialAttainmentEmployedIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AECredentialAttainmentPSCredentialIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AECredentialAttainmentPSEnrollmentIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

    }
}
