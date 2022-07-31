//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   IAssessmentForm.cs
//**********************************************************

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentForm
     /// </summary>
    public partial interface IAssessmentForm
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.FormNumber non nullable property
        /// </summary>
        System.String FormNumber { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.Version non nullable property
        /// </summary>
        System.String Version { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.PublishedDate nullable property
        /// </summary>
        System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AccommodationList non nullable property
        /// </summary>
        System.String AccommodationList { get; set; }

        /// <summary>
        /// The beginning date of the time period in which the form is intended to be administered.
        /// </summary>
    System.DateTime? IntendedAdministrationStartDate { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.IntendedAdministrationEndDate nullable property
        /// </summary>
        System.DateTime? IntendedAdministrationEndDate { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AssessmentItemBankIdentifier non nullable property
        /// </summary>
        System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.AssessmentItemBankName non nullable property
        /// </summary>
        System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.PlatformsSupported non nullable property
        /// </summary>
        System.String PlatformsSupported { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguage"/> model
        /// </summary>
        Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// </summary>
    System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid? LearningResourceId { get; set; }

        /// <summary>
        /// Indicates that the assessment form was generated using an algorithm rather than a fixed form.
        /// </summary>
    System.Boolean? AssessmentFormAdaptiveIndicator { get; set; }

        /// <summary>
        /// An identifier for algorithm used to generate a custom form for an adaptive test.
        /// </summary>
    System.String AssessmentFormAlgorithmIdentifier { get; set; }

        /// <summary>
        /// The version of the algorithm used to generate a custom form for an adaptive test.
        /// </summary>
    System.String AssessmentFormAlgorithmVersion { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form.
        /// </summary>
    System.String AssessmentFormGUID { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentForm.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
