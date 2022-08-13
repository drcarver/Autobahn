//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentSubtestELDevelopmentalDomain.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtestELDevelopmentalDomain Interface
     /// </summary>
    public partial interface IAssessmentSubtestELDevelopmentalDomain : IAutobahnBase
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid RefAssessmentELDevelopmentalDomainId { get; set; }

    }
}
