//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationTelephone.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationTelephone Interface
     /// </summary>
    public partial interface IOrganizationTelephone : IAutobahnBase
    {
        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        Guid? RefInstitutionTelephoneTypeId { get; set; }

    }
}
