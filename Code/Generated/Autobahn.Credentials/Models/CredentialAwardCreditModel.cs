//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardCreditModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAwardCredit Model
     /// </summary>
    public partial class CredentialAwardCreditModel : AutobahnBase, Interfaces.ICredentialAwardCredit
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
