//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileContent.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileContent Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileContent : IAutobahnBase
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        Guid? RefAssessmentNeedHazardTypeId { get; set; }

    }
}
