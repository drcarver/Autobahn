//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationLocationModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationLocationModel Interface
     /// </summary>
    public partial interface IOrganizationLocationModel : IAutobahnBase
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
