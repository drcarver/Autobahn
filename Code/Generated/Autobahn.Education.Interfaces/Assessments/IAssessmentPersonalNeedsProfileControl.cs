//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileControl.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileControl Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileControl : IAutobahnBase
    {
        #region IAssessmentPersonalNeedsProfileControl
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

        #endregion
    }
}
