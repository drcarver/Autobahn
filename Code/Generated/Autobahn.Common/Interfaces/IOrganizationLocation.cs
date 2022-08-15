//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationLocation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationLocation Interface
     /// </summary>
    public partial interface IOrganizationLocation : IAutobahnBase
    {
        /// <summary>
        /// The type of address listed for an organization.
        /// </summary>
        Guid? RefOrganizationLocationTypeId { get; set; }

    }
}
