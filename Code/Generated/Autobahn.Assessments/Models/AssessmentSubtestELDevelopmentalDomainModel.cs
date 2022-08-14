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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefAssessmentELDevelopmentalDomainId { get; set; }

    }
}
