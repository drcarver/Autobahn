//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentELDevelopmentalDomain.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentELDevelopmentalDomain
     /// </summary>
    public partial class AssessmentELDevelopmentalDomain : AutobahnBase, Interfaces.IAssessmentELDevelopmentalDomain
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentELDevelopmentalDomain"/> model
        /// </summary>
        public Guid RefAssessmentELDevelopmentalDomainId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
