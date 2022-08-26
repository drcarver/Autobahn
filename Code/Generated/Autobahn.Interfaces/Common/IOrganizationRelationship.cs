//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationRelationship.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationRelationship Interface
     /// </summary>
    public partial interface IOrganizationRelationship : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IParentOrganization"/> model
        /// </summary>
        Guid ParentOrganizationId { get; set; }

        /// <summary>
        /// Organization Relationship Type
        /// <para>
        /// The nature of one organization's relationship to another.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20886">Organization Relationship Type</a>
        /// </para>
        /// </summary>
        Guid? RefOrganizationRelationshipId { get; set; }

    }
}
