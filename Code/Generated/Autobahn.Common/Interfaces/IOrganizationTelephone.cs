//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationTelephone.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationTelephone
     /// </summary>
    public partial interface IOrganizationTelephone : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationTelephone.TelephoneNumber non nullable property
        /// </summary>
        System.String TelephoneNumber { get; set; }

        /// <summary>
        /// Defines the OrganizationTelephone.PrimaryTelephoneNumberIndicator non nullable property
        /// </summary>
        System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstitutionTelephoneType"/> model
        /// </summary>
        Guid? RefInstitutionTelephoneTypeId { get; set; }

        /// <summary>
        /// Defines the OrganizationTelephone.DoNotPublishIndicator nullable property
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        Guid? RefTelephoneNumberListedStatusId { get; set; }

    }
}
