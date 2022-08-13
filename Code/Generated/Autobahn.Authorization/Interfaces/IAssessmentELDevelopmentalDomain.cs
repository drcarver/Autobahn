//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentELDevelopmentalDomain.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentELDevelopmentalDomain Interface
     /// </summary>
    public partial interface IAssessmentELDevelopmentalDomain : IAutobahnBase
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid RefAssessmentELDevelopmentalDomainId { get; set; }

    }
}
