//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationImage.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationImage Interface
     /// </summary>
    public partial interface IOrganizationImage : IAutobahnBase
    {
        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing the Organization.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing the Organization.
        /// </summary>
        System.String URL { get; set; }

    }
}
