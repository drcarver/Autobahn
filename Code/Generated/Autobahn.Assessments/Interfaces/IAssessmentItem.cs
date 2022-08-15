//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItem.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentItem Interface
     /// </summary>
    public partial interface IAssessmentItem : IAutobahnBase
    {
        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        Guid? RefAssessmentItemTypeId { get; set; }

    }
}
