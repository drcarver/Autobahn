//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileScreenEnhancement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileScreenEnhancement Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileScreenEnhancement : IAutobahnBase
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
