//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   AssessmentForm.cs
//**********************************************************

using Autobahn.Assessments.Interfaces;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentForm
     /// </summary>
    public partial class AssessmentForm : IAssessmentForm
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        public Guid AssessmentFormId { get; set; }

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
        /// The beginning date of the time period in which the form is intended to be administered.
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
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
    public System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        /// <summary>
        /// Indicates that the assessment form was generated using an algorithm rather than a fixed form.
        /// </summary>
    public System.Boolean? AssessmentFormAdaptiveIndicator { get; set; }

        /// <summary>
        /// An identifier for algorithm used to generate a custom form for an adaptive test.
        /// </summary>
    public System.String AssessmentFormAlgorithmIdentifier { get; set; }

        /// <summary>
        /// The version of the algorithm used to generate a custom form for an adaptive test.
        /// </summary>
    public System.String AssessmentFormAlgorithmVersion { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form.
        /// </summary>
    public System.String AssessmentFormGUID { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
