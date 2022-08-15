//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationRelationship.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationRelationship Interface
     /// </summary>
    public partial interface IOrganizationRelationship : IAutobahnBase
    {
        /// <summary>
        /// The nature of one organization's relationship to another.
        /// </summary>
        Guid? RefOrganizationRelationshipId { get; set; }

    }
}
