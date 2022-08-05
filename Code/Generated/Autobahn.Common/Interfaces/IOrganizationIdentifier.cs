//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationIdentifier.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationIdentifier
     /// </summary>
    public partial interface IOrganizationIdentifier : IAutobahnBase
    {
        /// <summary>
        /// Defines the OrganizationIdentifier.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentificationSystem"/> model
        /// </summary>
        Guid? RefOrganizationIdentificationSystemId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentifierType"/> model
        /// </summary>
        Guid? RefOrganizationIdentifierTypeId { get; set; }

    }
}
