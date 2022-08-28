//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileScreenEnhancement.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileScreenEnhancement Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileScreenEnhancement : IAutobahnBase
    {
        #region IAssessmentPersonalNeedsProfileScreenEnhancement
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

        #endregion
    }
}
