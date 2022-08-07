//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCredentialDefStatusTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCredentialDefStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCredentialDefStatusTypeModel"> List
         /// </summary>
        public static List<RefCredentialDefStatusTypeModel> RefCredentialDefStatusTypeList = new List<RefCredentialDefStatusTypeModel>
        {
            new RefCredentialDefStatusType { Id=Guid.Parse("bf97efa6-8d4d-45ea-8fc0-c3a850582c2a"), Code="Active", Description="Active", Definition="Awards of the credential are ongoing.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("5be22ee7-d471-4ac5-9f0c-568c688ac487"), Code="Deprecated", Description="Deprecated", Definition="The credential is no longer awarded.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("0218ada9-9ec8-4edd-af24-dd54824c1075"), Code="Probationary", Description="Probationary", Definition="The credential award is provisional or temporary; frequently pending further assessment of qualification.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("a1ce0ae2-aca9-43d2-b5d5-f42b944af1b4"), Code="Superseded", Description="Superseded", Definition="The credential is no longer awarded and has been superseded by another credential.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefCredentialDefStatusType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCredentialDefStatusTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCredentialDefStatusType { Id=Guid.Parse("bf97efa6-8d4d-45ea-8fc0-c3a850582c2a"), Description="Active", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("5be22ee7-d471-4ac5-9f0c-568c688ac487"), Description="Deprecated", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("0218ada9-9ec8-4edd-af24-dd54824c1075"), Description="Probationary", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefStatusType { Id=Guid.Parse("a1ce0ae2-aca9-43d2-b5d5-f42b944af1b4"), Description="Superseded", SortOrder=Convert.ToDecimal("") },
       };
   }
}
