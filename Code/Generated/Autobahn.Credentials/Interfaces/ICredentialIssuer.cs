//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialIssuer.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialIssuer Interface
     /// </summary>
    public partial interface ICredentialIssuer : IAutobahnBase
    {
        /// <summary>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </summary>
        System.String AwardIssuerOriginURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </summary>
        Guid? RefCTDLOrganizationTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </summary>
        System.String RevocationListURL { get; set; }

    }
}
