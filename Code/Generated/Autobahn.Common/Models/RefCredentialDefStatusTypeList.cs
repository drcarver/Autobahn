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
        public static List<RefCredentialDefStatusType> RefCredentialDefStatusTypeList = new List<RefCredentialDefStatusType>
        {
            new RefCredentialDefStatusType { Id=Guid.Parse("cdebd286-3237-4cca-acc4-641d8b75a5c3"), Code="Active", Description="Active", Definition="Awards of the credential are ongoing.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("8bae3f2c-a20c-4008-ab5e-2db6f2298016"), Code="Deprecated", Description="Deprecated", Definition="The credential is no longer awarded.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("ff1779f5-b02c-4556-9e0c-e358a8e44ab4"), Code="Probationary", Description="Probationary", Definition="The credential award is provisional or temporary; frequently pending further assessment of qualification.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("cee9bd01-5086-4ba8-b41a-08f9e5c1e717"), Code="Superseded", Description="Superseded", Definition="The credential is no longer awarded and has been superseded by another credential.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefCredentialDefStatusType Pick List
         /// </summary>
        public static List<RefCredentialDefStatusType> RefCredentialDefStatusTypePickList = new List<RefCredentialDefStatusType>
        {
            new RefCredentialDefStatusType { Id=Guid.Parse("cdebd286-3237-4cca-acc4-641d8b75a5c3"), Code="Active", Description="Active", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("8bae3f2c-a20c-4008-ab5e-2db6f2298016"), Code="Deprecated", Description="Deprecated", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("ff1779f5-b02c-4556-9e0c-e358a8e44ab4"), Code="Probationary", Description="Probationary", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("cee9bd01-5086-4ba8-b41a-08f9e5c1e717"), Code="Superseded", Description="Superseded", SortOrder=Convert.ToDecimal("") },
       };
   }
}
