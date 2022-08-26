//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentAdministrationOrganization.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentAdministrationOrganization Interface
     /// </summary>
    public partial interface IAssessmentAdministrationOrganization : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
        /// </summary>
        Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

    }
}
