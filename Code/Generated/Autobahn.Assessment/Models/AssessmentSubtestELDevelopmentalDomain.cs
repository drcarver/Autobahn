//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestELDevelopmentalDomain.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSubtestELDevelopmentalDomain
     /// </summary>
    public partial class AssessmentSubtestELDevelopmentalDomain : AutobahnBase, Interfaces.IAssessmentSubtestELDevelopmentalDomain
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

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
