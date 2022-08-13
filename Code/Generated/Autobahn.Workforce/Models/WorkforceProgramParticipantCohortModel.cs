//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipantCohortModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceProgramParticipantCohort Model
     /// </summary>
    public partial class WorkforceProgramParticipantCohortModel : AutobahnBase, Interfaces.IWorkforceProgramParticipantCohort
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String CohortDescription { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? CohortMedianEarnings { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
