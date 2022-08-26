//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationOrganizationModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAdministrationOrganization Model
     /// </summary>
    public partial class AssessmentAdministrationOrganizationModel : AutobahnBase, IAssessmentAdministrationOrganization
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
        /// </summary>
        public Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

    }
}
