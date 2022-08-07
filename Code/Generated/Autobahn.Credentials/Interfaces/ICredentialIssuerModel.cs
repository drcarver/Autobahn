//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialIssuerModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialIssuerModel Interface
     /// </summary>
    public partial interface ICredentialIssuerModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.AwardIssuerOriginURL non nullable property
        /// </summary>
        System.String AwardIssuerOriginURL { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.RevocationListURL non nullable property
        /// </summary>
        System.String RevocationListURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        Guid? RefCTDLOrganizationTypeId { get; set; }

    }
}
