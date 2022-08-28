//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentEldevelopmentalDomain.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentEldevelopmentalDomain Interface
     /// </summary>
    public partial interface IAssessmentEldevelopmentalDomain : IAutobahnBase
    {
        #region IAssessmentEldevelopmentalDomain
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
        /// </summary>
        Guid RefAssessmentEldevelopmentalDomainId { get; set; }

        #endregion
    }
}
