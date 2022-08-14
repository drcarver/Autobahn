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
        /// The name of a given assessment form.
        /// </summary>
        System.String AccommodationList { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.Boolean? AssessmentFormAdaptiveIndicator { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.String AssessmentFormAlgorithmIdentifier { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.String AssessmentFormAlgorithmVersion { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.String AssessmentFormGUID { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.String FormNumber { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.DateTime? IntendedAdministrationEndDate { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.DateTime? IntendedAdministrationStartDate { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        Guid? LearningResourceId { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.String PlatformsSupported { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        System.String Version { get; set; }

    }
}
