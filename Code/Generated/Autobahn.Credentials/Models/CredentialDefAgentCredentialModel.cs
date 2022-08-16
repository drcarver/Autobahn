//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentCredentialModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefAgentCredential Model
     /// </summary>
    public partial class CredentialDefAgentCredentialModel : AutobahnBase, Interfaces.ICredentialDefAgentCredential
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
