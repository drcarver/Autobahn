//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentAdministration_OrganizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentAdministration_OrganizationModel Interface
     /// </summary>
    public partial interface IAssessmentAdministration_OrganizationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

    }
}
