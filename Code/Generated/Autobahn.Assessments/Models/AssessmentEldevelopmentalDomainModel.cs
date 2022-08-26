//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentEldevelopmentalDomainModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentEldevelopmentalDomain Model
     /// </summary>
    public partial class AssessmentEldevelopmentalDomainModel : AutobahnBase, IAssessmentEldevelopmentalDomain
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessment"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
        /// </summary>
        public Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    }
}
