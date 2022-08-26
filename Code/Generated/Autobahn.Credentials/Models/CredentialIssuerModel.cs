//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerModel.cs
//***************************************************************************

using Autobahn.Interfaces.Credentials;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialIssuer Model
     /// </summary>
    public partial class CredentialIssuerModel : AutobahnBase, ICredentialIssuer
    {
        public System.String AwardIssuerOriginUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCtdlorganizationType"/> model
        /// </summary>
        public Guid? RefCtdlorganizationTypeId { get; set; }

        public System.String RevocationListUrl { get; set; }

    }
}
