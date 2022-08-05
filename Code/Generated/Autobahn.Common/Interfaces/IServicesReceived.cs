//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServicesReceived.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServicesReceived
     /// </summary>
    public partial interface IServicesReceived : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ServicesReceived.FullTimeEquivalency nullable property
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServicePlan"/> model
        /// </summary>
        Guid ServicePlanId { get; set; }

    }
}
