//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemApipDescriptionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemApipDescription Model
     /// </summary>
    public partial class AssessmentItemApipDescriptionModel : AutobahnBase, Interfaces.IAssessmentItemApipDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
