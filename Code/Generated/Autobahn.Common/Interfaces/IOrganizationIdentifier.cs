//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationIdentifier.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationIdentifier Interface
     /// </summary>
    public partial interface IOrganizationIdentifier : IAutobahnBase
    {
        /// <summary>
        /// A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        Guid? RefOrganizationIdentifierTypeId { get; set; }

    }
}
