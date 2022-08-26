//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentSessionModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12studentSession Model
     /// </summary>
    public partial class K12studentSessionModel : AutobahnBase, IK12studentSession
    {
        public Decimal? GradePointAverageGivenSession { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
