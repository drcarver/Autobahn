//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentActivity.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentActivity
     /// </summary>
    public partial interface IK12StudentActivity : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentActivity.ActivityTimeInvolved nullable property
        /// </summary>
        System.Decimal? ActivityTimeInvolved { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementType"/> model
        /// </summary>
        Guid? RefActivityTimeMeasurementTypeId { get; set; }

    }
}
