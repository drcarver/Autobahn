//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormSection Model
     /// </summary>
    public partial class AssessmentFormSectionModel : AutobahnBase, Interfaces.IAssessmentFormSection
    {
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
        public Guid? GUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Identifier { get; set; }

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
        public  RefAssessmentFormSectionIdentificationSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SectionReentry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SectionSealed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SectionTimeLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Version { get; set; }

    }
}
