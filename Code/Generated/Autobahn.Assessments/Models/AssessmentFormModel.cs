//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentForm Model
     /// </summary>
    public partial class AssessmentFormModel : AutobahnBase, Interfaces.IAssessmentForm
    {
        /// <summary>
        /// 
        /// </summary>
        public  AccommodationList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentFormAdaptiveIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentFormAlgorithmIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentFormAlgorithmVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentFormGUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentItemBankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FormNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IntendedAdministrationEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IntendedAdministrationStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PlatformsSupported { get; set; }

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
        public  RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Version { get; set; }

    }
}
