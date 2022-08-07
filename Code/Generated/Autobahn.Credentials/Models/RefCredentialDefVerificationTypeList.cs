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
        /// The complete <see cref="RefCredentialDefVerificationTypeModel"> List
         /// </summary>
        public static List<RefCredentialDefVerificationTypeModel> RefCredentialDefVerificationTypeList = new List<RefCredentialDefVerificationTypeModel>
        {
            new RefCredentialDefVerificationType { Id=Guid.Parse("4d0f51c1-b3f8-4908-917b-0d9be271118f"), Code="BadgeClaim", Description="Badge Claim", Definition="Verifiable representation of a credential holder's badge that is controlled by the credentialing organization.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefVerificationType { Id=Guid.Parse("c482323d-40ba-4327-83f7-b9268aaf9d8f"), Code="TranscriptClaim", Description="Transcript Claim", Definition="Verifiable representation of postsecondary courses and degrees that is controlled by the credentialing organization.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefVerificationType { Id=Guid.Parse("eb94cd73-be9c-4b03-b8dd-1f9d141c53d8"), Code="VerifiedClaim", Description="Verified Claim", Definition="Verifiable representation of the credential holder's credential that is controlled by the credentialing organization.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefCredentialDefVerificationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCredentialDefVerificationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCredentialDefVerificationType { Id=Guid.Parse("4d0f51c1-b3f8-4908-917b-0d9be271118f"), Description="Badge Claim", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefVerificationType { Id=Guid.Parse("c482323d-40ba-4327-83f7-b9268aaf9d8f"), Description="Transcript Claim", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefVerificationType { Id=Guid.Parse("eb94cd73-be9c-4b03-b8dd-1f9d141c53d8"), Description="Verified Claim", SortOrder=Convert.ToDecimal("") },
       };
   }
}
