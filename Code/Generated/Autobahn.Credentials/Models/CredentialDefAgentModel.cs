//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefAgent Model
     /// </summary>
    public partial class CredentialDefAgentModel : AutobahnBase, Interfaces.ICredentialDefAgent
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCredentialDefAgentRoleTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get; set; }

    }
}
