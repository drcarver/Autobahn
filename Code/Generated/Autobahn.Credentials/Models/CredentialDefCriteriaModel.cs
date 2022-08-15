//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriteriaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefCriteria Model
     /// </summary>
    public partial class CredentialDefCriteriaModel : AutobahnBase, Interfaces.ICredentialDefCriteria
    {
        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String Criteria { get; set; }

    }
}
