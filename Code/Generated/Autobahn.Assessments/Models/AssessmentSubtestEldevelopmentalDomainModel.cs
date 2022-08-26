//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestEldevelopmentalDomainModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestEldevelopmentalDomain Model
     /// </summary>
    public partial class AssessmentSubtestEldevelopmentalDomainModel : AutobahnBase, IAssessmentSubtestEldevelopmentalDomain
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
        /// </summary>
        public Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    }
}
