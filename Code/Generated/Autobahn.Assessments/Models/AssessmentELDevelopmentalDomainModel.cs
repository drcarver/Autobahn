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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RefAssessmentELDevelopmentalDomainId { get; set; }

    }
}
