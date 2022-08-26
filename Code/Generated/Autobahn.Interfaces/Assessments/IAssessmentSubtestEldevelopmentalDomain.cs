//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSubtestEldevelopmentalDomain.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentSubtestEldevelopmentalDomain Interface
     /// </summary>
    public partial interface IAssessmentSubtestEldevelopmentalDomain : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
        /// </summary>
        Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    }
}
