//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentSession.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentSession
     /// </summary>
    public partial class K12StudentSession : AutobahnBase, Interfaces.IK12StudentSession
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the K12StudentSession.GradePointAverageGivenSession nullable property
        /// </summary>
        public System.Decimal? GradePointAverageGivenSession { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
