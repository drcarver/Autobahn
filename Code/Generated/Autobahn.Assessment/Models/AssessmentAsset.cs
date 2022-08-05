//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAsset.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentAsset
     /// </summary>
    public partial class AssessmentAsset : AutobahnBase, Interfaces.IAssessmentAsset
    {
        /// <summary>
        /// Defines the AssessmentAsset.Version non nullable property
        /// </summary>
        public System.String Version { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.PublishedDate nullable property
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.RefAssessmentAssestIdentifierType nullable property
        /// </summary>
        public System.Int32? RefAssessmentAssestIdentifierType { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAssetType"/> model
        /// </summary>
        public Guid? RefAssessmentAssetTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.Owner non nullable property
        /// </summary>
        public System.String Owner { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguage"/> model
        /// </summary>
        public Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.ContentXML non nullable property
        /// </summary>
        public System.String ContentXML { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.ContentMimeType non nullable property
        /// </summary>
        public System.String ContentMimeType { get; set; }

        /// <summary>
        /// Defines the AssessmentAsset.ContentUrl non nullable property
        /// </summary>
        public System.String ContentUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
