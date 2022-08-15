//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialIssuer Model
     /// </summary>
    public partial class CredentialIssuerModel : AutobahnBase, Interfaces.ICredentialIssuer
    {
        /// <summary>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </summary>
        public System.String AwardIssuerOriginURL { get; set; }

    }
}
