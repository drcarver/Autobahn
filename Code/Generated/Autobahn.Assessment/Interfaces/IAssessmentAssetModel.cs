//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentAssetModel Interface
     /// </summary>
    public partial interface IAssessmentAssetModel : IAutobahnBase
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

    }
}
