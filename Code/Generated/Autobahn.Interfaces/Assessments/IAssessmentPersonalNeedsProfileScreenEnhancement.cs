//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileScreenEnhancement.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileScreenEnhancement Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileScreenEnhancement : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
