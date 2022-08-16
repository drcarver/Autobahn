//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssessmentAdministrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAssessmentAdministration Model
     /// </summary>
    public partial class AssessmentAssessmentAdministrationModel : AutobahnBase, Interfaces.IAssessmentAssessmentAdministration
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
