//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentAsset.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentAsset
     /// </summary>
    public partial interface IAssessmentAsset
    {
        /// <summary>
        /// Defines the AssessmentAsset.Version non nullable property
        /// </summary>
        System.String Version { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.PublishedDate nullable property
        /// </summary>
        System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.RefAssessmentAssestIdentifierType nullable property
        /// </summary>
        System.Int32? RefAssessmentAssestIdentifierType { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAssetType"/> model
        /// </summary>
        Guid? RefAssessmentAssetTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.Owner non nullable property
        /// </summary>
        System.String Owner { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguage"/> model
        /// </summary>
        Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.ContentXML non nullable property
        /// </summary>
        System.String ContentXML { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.ContentMimeType non nullable property
        /// </summary>
        System.String ContentMimeType { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.ContentUrl non nullable property
        /// </summary>
        System.String ContentUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid? LearningResourceId { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.RecordEndDateTime nullable property
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
