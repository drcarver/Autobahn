//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileDisplay.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileDisplay Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileDisplay : IAutobahnBase
    {
        #region IAssessmentPersonalNeedsProfileDisplay
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

        #endregion
    }
}
