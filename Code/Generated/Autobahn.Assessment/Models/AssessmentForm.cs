//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentForm.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentForm
     /// </summary>
    public partial class AssessmentForm : AutobahnBase, Interfaces.IAssessmentForm
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.FormNumber non nullable property
        /// </summary>
        public System.String FormNumber { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.Version non nullable property
        /// </summary>
        public System.String Version { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.PublishedDate nullable property
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AccommodationList non nullable property
        /// </summary>
        public System.String AccommodationList { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.IntendedAdministrationStartDate nullable property
        /// </summary>
        public System.DateTime? IntendedAdministrationStartDate { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.IntendedAdministrationEndDate nullable property
        /// </summary>
        public System.DateTime? IntendedAdministrationEndDate { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AssessmentItemBankIdentifier non nullable property
        /// </summary>
        public System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AssessmentItemBankName non nullable property
        /// </summary>
        public System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.PlatformsSupported non nullable property
        /// </summary>
        public System.String PlatformsSupported { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguage"/> model
        /// </summary>
        public Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AssessmentSecureIndicator nullable property
        /// </summary>
        public System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AssessmentFormAdaptiveIndicator nullable property
        /// </summary>
        public System.Boolean? AssessmentFormAdaptiveIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AssessmentFormAlgorithmIdentifier non nullable property
        /// </summary>
        public System.String AssessmentFormAlgorithmIdentifier { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AssessmentFormAlgorithmVersion non nullable property
        /// </summary>
        public System.String AssessmentFormAlgorithmVersion { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AssessmentFormGUID non nullable property
        /// </summary>
        public System.String AssessmentFormGUID { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
