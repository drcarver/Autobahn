//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAsset Model
     /// </summary>
    public partial class AssessmentAssetModel : AutobahnBase, Interfaces.IAssessmentAsset
    {
        /// <summary>
        /// 
        /// </summary>
        public  ContentMimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ContentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ContentXML { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PublishedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentAssestIdentifierType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentAssetTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Version { get; set; }

    }
}
