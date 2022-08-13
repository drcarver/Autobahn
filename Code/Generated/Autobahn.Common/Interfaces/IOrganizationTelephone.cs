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
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        Guid? RefInstitutionTelephoneTypeId { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        Guid? RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        System.String TelephoneNumber { get; set; }

    }
}
