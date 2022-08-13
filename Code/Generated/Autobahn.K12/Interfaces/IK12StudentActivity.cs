//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentActivity.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentActivity Interface
     /// </summary>
    public partial interface IK12StudentActivity : IAutobahnBase
    {
        /// <summary>
        /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        System.Decimal? ActivityTimeInvolved { get; set; }

        /// <summary>
        /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        Guid? RefActivityTimeMeasurementTypeId { get; set; }

    }
}
