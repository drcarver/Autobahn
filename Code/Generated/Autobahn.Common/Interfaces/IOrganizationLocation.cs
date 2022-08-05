//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationLocation.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationLocation
     /// </summary>
    public partial interface IOrganizationLocation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Location"/> model
        /// </summary>
        Guid LocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationLocationType"/> model
        /// </summary>
        Guid? RefOrganizationLocationTypeId { get; set; }

    }
}
