//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentAsset.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentAsset Interface
     /// </summary>
    public partial interface IAssessmentAsset : IAutobahnBase
    {
        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        System.String ContentMimeType { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        System.String ContentUrl { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        System.String ContentXML { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        Guid? LearningResourceId { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        System.String Owner { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        System.Int32? RefAssessmentAssestIdentifierType { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        Guid? RefAssessmentAssetTypeId { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        System.String Version { get; set; }

    }
}
