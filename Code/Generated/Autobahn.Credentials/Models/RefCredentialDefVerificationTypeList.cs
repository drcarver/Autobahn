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
        public static List<RefCredentialDefVerificationType> RefCredentialDefVerificationTypeList = new List<RefCredentialDefVerificationType> =
        {
            new RefCredentialDefVerificationType { Id=Guid.Parse("5aa2ce5b-8572-466b-a7f6-2acb6b7b3602"), Code="Verifiable representation of a credential holder's badge that is controlled by the credentialing organization.", Description="BadgeClaim", Definition="", SortOrder=0 },
            new RefCredentialDefVerificationType { Id=Guid.Parse("9052edee-ed70-4da0-a3a9-7acc74c0530f"), Code="Verifiable representation of postsecondary courses and degrees that is controlled by the credentialing organization.", Description="TranscriptClaim", Definition="", SortOrder=0 },
            new RefCredentialDefVerificationType { Id=Guid.Parse("fea9bf74-2d35-440b-abf9-dc8981b895cc"), Code="Verifiable representation of the credential holder's credential that is controlled by the credentialing organization.", Description="VerifiedClaim", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCredentialDefVerificationType Pick List
         /// </summary>
        public static List<RefCredentialDefVerificationType> RefCredentialDefVerificationTypePickList = new List<RefCredentialDefVerificationType> =
        {
            new RefCredentialDefVerificationType { Id=Guid.Parse("5aa2ce5b-8572-466b-a7f6-2acb6b7b3602"), Code="Verifiable representation of a credential holder's badge that is controlled by the credentialing organization.", SortOrder=0 },
            new RefCredentialDefVerificationType { Id=Guid.Parse("9052edee-ed70-4da0-a3a9-7acc74c0530f"), Code="Verifiable representation of postsecondary courses and degrees that is controlled by the credentialing organization.", SortOrder=0 },
            new RefCredentialDefVerificationType { Id=Guid.Parse("fea9bf74-2d35-440b-abf9-dc8981b895cc"), Code="Verifiable representation of the credential holder's credential that is controlled by the credentialing organization.", SortOrder=0 },
       };
   }
}
