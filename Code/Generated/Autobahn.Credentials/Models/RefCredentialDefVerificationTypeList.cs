//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   RefCredentialDefVerificationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The list of RefCredentialDefVerificationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCredentialDefVerificationType"> List
         /// </summary>
        public static List<RefCredentialDefVerificationType> RefCredentialDefVerificationTypeList = new List<RefCredentialDefVerificationType>
        {
            new RefCredentialDefVerificationType { Id=Guid.Parse("d3ae4ff7-8d49-4962-b11f-c2012a67d71d"), Code="BadgeClaim", Description="Badge Claim", Definition="Verifiable representation of a credential holder's badge that is controlled by the credentialing organization.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefVerificationType { Id=Guid.Parse("08283fc4-9167-4272-97c5-dd0e07029985"), Code="TranscriptClaim", Description="Transcript Claim", Definition="Verifiable representation of postsecondary courses and degrees that is controlled by the credentialing organization.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefVerificationType { Id=Guid.Parse("eff8fc37-82cb-4ef6-beef-2acfbc92ed3f"), Code="VerifiedClaim", Description="Verified Claim", Definition="Verifiable representation of the credential holder's credential that is controlled by the credentialing organization.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefCredentialDefVerificationType Pick List
         /// </summary>
        public static List<RefCredentialDefVerificationType> RefCredentialDefVerificationTypePickList = new List<RefCredentialDefVerificationType>
        {
            new RefCredentialDefVerificationType { Id=Guid.Parse("d3ae4ff7-8d49-4962-b11f-c2012a67d71d"), Code="BadgeClaim", Description="Badge Claim", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefVerificationType { Id=Guid.Parse("08283fc4-9167-4272-97c5-dd0e07029985"), Code="TranscriptClaim", Description="Transcript Claim", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefVerificationType { Id=Guid.Parse("eff8fc37-82cb-4ef6-beef-2acfbc92ed3f"), Code="VerifiedClaim", Description="Verified Claim", SortOrder=Convert.ToDecimal("") },
       };
   }
}
