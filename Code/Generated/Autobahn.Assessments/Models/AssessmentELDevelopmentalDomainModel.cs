//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentELDevelopmentalDomainModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentELDevelopmentalDomain Model
     /// </summary>
    public partial class AssessmentELDevelopmentalDomainModel : AutobahnBase, Interfaces.IAssessmentELDevelopmentalDomain
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
