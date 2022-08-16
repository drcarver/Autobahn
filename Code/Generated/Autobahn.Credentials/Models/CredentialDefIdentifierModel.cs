//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefIdentifierModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefIdentifier Model
     /// </summary>
    public partial class CredentialDefIdentifierModel : AutobahnBase, Interfaces.ICredentialDefIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Identifier { get; set; }

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
        public  RefCredentialIdentifierSystemId { get; set; }

    }
}
