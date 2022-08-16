//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormAssessmentFormSection Model
     /// </summary>
    public partial class AssessmentFormAssessmentFormSectionModel : AutobahnBase, Interfaces.IAssessmentFormAssessmentFormSection
    {
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
        public Guid? SequenceNumber { get; set; }

    }
}
