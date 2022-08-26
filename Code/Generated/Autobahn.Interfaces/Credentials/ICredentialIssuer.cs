//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialIssuer.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Credentials
{
     /// <summary>
     /// The ICredentialIssuer Interface
     /// </summary>
    public partial interface ICredentialIssuer : IAutobahnBase
    {
        System.String AwardIssuerOriginUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCtdlorganizationType"/> model
        /// </summary>
        Guid? RefCtdlorganizationTypeId { get; set; }

        System.String RevocationListUrl { get; set; }

    }
}
