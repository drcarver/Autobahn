//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSubtestEldevelopmentalDomain.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentSubtestEldevelopmentalDomain Interface
     /// </summary>
    public partial interface IAssessmentSubtestEldevelopmentalDomain : IAutobahnBase
    {
        #region IAssessmentSubtestEldevelopmentalDomain
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
        /// </summary>
        Guid RefAssessmentEldevelopmentalDomainId { get; set; }

        #endregion
    }
}
