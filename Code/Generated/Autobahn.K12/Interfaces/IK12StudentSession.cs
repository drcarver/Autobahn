//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentSession.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentSession Interface
     /// </summary>
    public partial interface IK12StudentSession : IAutobahnBase
    {
        /// <summary>
        /// A measure of average performance in all courses taken by a person during a given session. This is obtained by dividing the total grade points received by the number of credits attempted for the same session.
        /// </summary>
        System.Decimal? GradePointAverageGivenSession { get; set; }

        /// <summary>
        /// A measure of average performance in all courses taken by a person during a given session. This is obtained by dividing the total grade points received by the number of credits attempted for the same session.
        /// </summary>
        Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// A measure of average performance in all courses taken by a person during a given session. This is obtained by dividing the total grade points received by the number of credits attempted for the same session.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
