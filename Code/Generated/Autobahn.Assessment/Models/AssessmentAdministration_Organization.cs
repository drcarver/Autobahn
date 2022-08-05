//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAdministration_Organization.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentAdministration_Organization
     /// </summary>
    public partial class AssessmentAdministration_Organization : AutobahnBase, Interfaces.IAssessmentAdministration_Organization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        public Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
