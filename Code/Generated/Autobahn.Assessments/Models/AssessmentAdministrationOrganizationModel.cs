//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationOrganizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAdministrationOrganization Model
     /// </summary>
    public partial class AssessmentAdministrationOrganizationModel : AutobahnBase, Interfaces.IAssessmentAdministrationOrganization
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationId { get; set; }

    }
}
