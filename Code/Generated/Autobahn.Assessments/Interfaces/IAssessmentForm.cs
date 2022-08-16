//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentForm.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentForm Interface
     /// </summary>
    public partial interface IAssessmentForm : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AccommodationList { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentFormAdaptiveIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentFormAlgorithmIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentFormAlgorithmVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentFormGUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentItemBankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FormNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IntendedAdministrationEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IntendedAdministrationStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PlatformsSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PublishedDate { get; set; }

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
         RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Version { get; set; }

    }
}
