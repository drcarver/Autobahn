//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServicesReceived.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ServicesReceived
     /// </summary>
    public partial class ServicesReceived : AutobahnBase, Interfaces.IServicesReceived
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ServicesReceived.FullTimeEquivalency nullable property
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServicePlan"/> model
        /// </summary>
        public Guid ServicePlanId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
