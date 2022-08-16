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
        /// 
        /// </summary>
        public  AdvancedStandingDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AdvancedStandingURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ApproverName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CompletionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CredentialAwardEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CredentialAwardStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EvidenceURL { get; set; }

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
        public  RevokedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RevokedIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RevokedReason { get; set; }

    }
}
