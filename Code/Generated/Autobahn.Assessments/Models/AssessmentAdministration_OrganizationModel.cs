//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministration_OrganizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAdministration_Organization Model
     /// </summary>
    public partial class AssessmentAdministration_OrganizationModel : AutobahnBase, Interfaces.IAssessmentAdministration_Organization
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
