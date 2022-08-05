//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentSession.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentSession
     /// </summary>
    public partial interface IK12StudentSession : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the K12StudentSession.GradePointAverageGivenSession nullable property
        /// </summary>
        System.Decimal? GradePointAverageGivenSession { get; set; }

    }
}
