//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOtherNameTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefOtherNameType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOtherNameTypeModel"> List
         /// </summary>
        public static List<RefOtherNameTypeModel> RefOtherNameTypeList = new List<RefOtherNameTypeModel>
        {
            new RefOtherNameType { Id=Guid.Parse("74803a5a-50e2-48e4-95f1-45717c1b4513"), Code="Alias", Description="Alias", Definition="The value specified for Other Name is the person's Alias.", SortOrder=Convert.ToDecimal("1.00") },
            new RefOtherNameType { Id=Guid.Parse("eee9fbcf-4d33-458c-a722-b54ef9c037d2"), Code="Nickname", Description="Nickname", Definition="The value specified for Other Name is the person's Nickname.", SortOrder=Convert.ToDecimal("2.00") },
            new RefOtherNameType { Id=Guid.Parse("4f984ae0-c1ec-45c7-92e4-5113c906013d"), Code="OtherName", Description="Other name", Definition="The value specified for Other Name is the person's Other name.", SortOrder=Convert.ToDecimal("3.00") },
            new RefOtherNameType { Id=Guid.Parse("fb7f3189-c274-4131-8a45-22d01ff1f9a5"), Code="PreviousLegalName", Description="Previous legal name", Definition="The value specified for Other Name is the person's Previous legal name.", SortOrder=Convert.ToDecimal("4.00") },
            new RefOtherNameType { Id=Guid.Parse("870de3c9-f66f-4820-b6f9-fd020fcfebe2"), Code="PreferredFamilyName", Description="Preferred Family Name", Definition="The value specified for Other Name is the person's Preferred Family Name.", SortOrder=Convert.ToDecimal("6.00") },
            new RefOtherNameType { Id=Guid.Parse("bf93b7c7-192c-459a-b593-e057cfeaeaf1"), Code="PreferredGivenName", Description="Preferred Given Name", Definition="The value specified for Other Name is the person's Preferred Given Name.", SortOrder=Convert.ToDecimal("8.00") },
            new RefOtherNameType { Id=Guid.Parse("252ba54a-521c-4b83-9de9-5d296a737774"), Code="FullName", Description="Full Name", Definition="The value specified for Other Name is the person's  Full Name.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefOtherNameType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefOtherNameTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefOtherNameType { Id=Guid.Parse("74803a5a-50e2-48e4-95f1-45717c1b4513"), Description="Alias", SortOrder=Convert.ToDecimal("1.00") },
            new RefOtherNameType { Id=Guid.Parse("eee9fbcf-4d33-458c-a722-b54ef9c037d2"), Description="Nickname", SortOrder=Convert.ToDecimal("2.00") },
            new RefOtherNameType { Id=Guid.Parse("4f984ae0-c1ec-45c7-92e4-5113c906013d"), Description="Other name", SortOrder=Convert.ToDecimal("3.00") },
            new RefOtherNameType { Id=Guid.Parse("fb7f3189-c274-4131-8a45-22d01ff1f9a5"), Description="Previous legal name", SortOrder=Convert.ToDecimal("4.00") },
            new RefOtherNameType { Id=Guid.Parse("870de3c9-f66f-4820-b6f9-fd020fcfebe2"), Description="Preferred Family Name", SortOrder=Convert.ToDecimal("6.00") },
            new RefOtherNameType { Id=Guid.Parse("bf93b7c7-192c-459a-b593-e057cfeaeaf1"), Description="Preferred Given Name", SortOrder=Convert.ToDecimal("8.00") },
            new RefOtherNameType { Id=Guid.Parse("252ba54a-521c-4b83-9de9-5d296a737774"), Description="Full Name", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
