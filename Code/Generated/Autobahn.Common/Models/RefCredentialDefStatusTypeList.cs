//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCredentialDefStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCredentialDefStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCredentialDefStatusType"> List
         /// </summary>
        public static List<RefCredentialDefStatusType> RefCredentialDefStatusTypeList = new List<RefCredentialDefStatusType> =
        {
            new RefCredentialDefStatusType { Id=Guid.Parse("747f241d-4af8-4088-8124-a773a09c4146"), Code="Awards of the credential are ongoing.", Description="Active", Definition="", SortOrder=0 },
            new RefCredentialDefStatusType { Id=Guid.Parse("82721f96-a10b-4ec9-8932-82c13e65cab0"), Code="The credential is no longer awarded.", Description="Deprecated", Definition="", SortOrder=0 },
            new RefCredentialDefStatusType { Id=Guid.Parse("2c24a671-ad3f-46ae-bc43-61af80af940d"), Code="The credential award is provisional or temporary; frequently pending further assessment of qualification.", Description="Probationary", Definition="", SortOrder=0 },
            new RefCredentialDefStatusType { Id=Guid.Parse("ffdf8227-6ca0-48ee-b855-3ceb1e373f2a"), Code="The credential is no longer awarded and has been superseded by another credential.", Description="Superseded", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCredentialDefStatusType Pick List
         /// </summary>
        public static List<RefCredentialDefStatusType> RefCredentialDefStatusTypePickList = new List<RefCredentialDefStatusType> =
        {
            new RefCredentialDefStatusType { Id=Guid.Parse("747f241d-4af8-4088-8124-a773a09c4146"), Code="Awards of the credential are ongoing.", SortOrder=0 },
            new RefCredentialDefStatusType { Id=Guid.Parse("82721f96-a10b-4ec9-8932-82c13e65cab0"), Code="The credential is no longer awarded.", SortOrder=0 },
            new RefCredentialDefStatusType { Id=Guid.Parse("2c24a671-ad3f-46ae-bc43-61af80af940d"), Code="The credential award is provisional or temporary; frequently pending further assessment of qualification.", SortOrder=0 },
            new RefCredentialDefStatusType { Id=Guid.Parse("ffdf8227-6ca0-48ee-b855-3ceb1e373f2a"), Code="The credential is no longer awarded and has been superseded by another credential.", SortOrder=0 },
       };
   }
}
