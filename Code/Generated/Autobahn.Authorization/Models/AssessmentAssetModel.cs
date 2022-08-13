//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentAsset Model
     /// </summary>
    public partial class AssessmentAssetModel : AutobahnBase, Interfaces.IAssessmentAsset
    {
        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String ContentMimeType { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String ContentUrl { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String ContentXML { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String Owner { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.Int32? RefAssessmentAssestIdentifierType { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public Guid? RefAssessmentAssetTypeId { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String Version { get; set; }

    }
}
