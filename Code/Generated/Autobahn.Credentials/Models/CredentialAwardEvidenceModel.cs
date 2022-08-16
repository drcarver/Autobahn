//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardEvidenceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAwardEvidence Model
     /// </summary>
    public partial class CredentialAwardEvidenceModel : AutobahnBase, Interfaces.ICredentialAwardEvidence
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
        public Guid? Statement { get; set; }

    }
}
