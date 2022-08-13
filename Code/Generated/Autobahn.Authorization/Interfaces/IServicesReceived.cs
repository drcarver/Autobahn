//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IServicesReceived.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IServicesReceived Interface
     /// </summary>
    public partial interface IServicesReceived : IAutobahnBase
    {
        /// <summary>
        /// Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.
        /// </summary>
        Guid ServicePlanId { get; set; }

    }
}
