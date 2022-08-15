//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAward Model
     /// </summary>
    public partial class CredentialAwardModel : AutobahnBase, Interfaces.ICredentialAward
    {
        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.DateTime? CredentialAwardStartDate { get; set; }

    }
}
