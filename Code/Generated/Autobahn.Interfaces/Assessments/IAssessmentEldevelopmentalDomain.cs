//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentEldevelopmentalDomain.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentEldevelopmentalDomain Interface
     /// </summary>
    public partial interface IAssessmentEldevelopmentalDomain : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
        /// </summary>
        Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    }
}
