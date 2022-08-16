//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialAward.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialAward Interface
     /// </summary>
    public partial interface ICredentialAward : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AdvancedStandingDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AdvancedStandingURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ApproverName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CompletionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CredentialAwardEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? CredentialAwardStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EvidenceURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RevokedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RevokedIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RevokedReason { get; set; }

    }
}
