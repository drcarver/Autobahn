//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestELDevelopmentalDomainModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestELDevelopmentalDomain Model
     /// </summary>
    public partial class AssessmentSubtestELDevelopmentalDomainModel : AutobahnBase, Interfaces.IAssessmentSubtestELDevelopmentalDomain
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
