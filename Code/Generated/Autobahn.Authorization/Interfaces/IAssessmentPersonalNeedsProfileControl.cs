//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileControl.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileControl Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileControl : IAutobahnBase
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
