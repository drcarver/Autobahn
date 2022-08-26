//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationLocation.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationLocation Interface
     /// </summary>
    public partial interface IOrganizationLocation : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILocation"/> model
        /// </summary>
        Guid LocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Address Type for Organization
        /// <para>
        /// The type of address listed for an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19644">Address Type for Organization</a>
        /// </para>
        /// </summary>
        Guid? RefOrganizationLocationTypeId { get; set; }

    }
}
