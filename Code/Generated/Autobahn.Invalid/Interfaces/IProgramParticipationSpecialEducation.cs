//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationSpecialEducation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationSpecialEducation Interface
     /// </summary>
    public partial interface IProgramParticipationSpecialEducation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AwaitingInitialIDEAEvaluationStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IDEAPlacementRationale { get; set; }

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
         RefIDEAEducationalEnvironmentECId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIDEAEducationalEnvironmentSchoolAgeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSpecialEducationExitReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SpecialEducationFTE { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SpecialEducationServicesExitDate { get; set; }

    }
}
