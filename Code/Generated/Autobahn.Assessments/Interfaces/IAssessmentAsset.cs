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
        /// 
        /// </summary>
         ContentMimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ContentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ContentXML { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Owner { get; set; }

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
         RefAssessmentAssestIdentifierType { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentAssetTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Version { get; set; }

    }
}
