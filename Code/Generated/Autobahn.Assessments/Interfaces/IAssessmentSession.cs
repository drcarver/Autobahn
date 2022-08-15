//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSession.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentSession Interface
     /// </summary>
    public partial interface IAssessmentSession : IAutobahnBase
    {
        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

    }
}
