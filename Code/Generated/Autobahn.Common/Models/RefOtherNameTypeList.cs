//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOtherNameTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefOtherNameType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOtherNameType"> List
         /// </summary>
        public static List<RefOtherNameType> RefOtherNameTypeList = new List<RefOtherNameType> =
        {
            new RefOtherNameType { Id=Guid.Parse("5ad0898a-c1a1-45cd-9b1d-3b447c83bf77"), Code="The value specified for Other Name is the person's Alias.", Description="Alias", Definition="", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("6fb7d2a7-8a75-4b54-8be4-67051fd7b733"), Code="The value specified for Other Name is the person's Nickname.", Description="Nickname", Definition="", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("eb9e1e4b-498a-460f-af27-677e4fd0cf3d"), Code="The value specified for Other Name is the person's Other name.", Description="OtherName", Definition="", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("e73e4728-4b7c-4c18-a793-46bbdcc7a185"), Code="The value specified for Other Name is the person's Previous legal name.", Description="PreviousLegalName", Definition="", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("09378f3f-c8bc-4edc-a966-1eb4a3b61419"), Code="The value specified for Other Name is the person's Preferred Family Name.", Description="PreferredFamilyName", Definition="", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("196dc5be-cb6f-44ef-9ac3-a3a8315113ab"), Code="The value specified for Other Name is the person's Preferred Given Name.", Description="PreferredGivenName", Definition="", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("911986c9-2b01-4e57-91fc-b4ded0accd9b"), Code="The value specified for Other Name is the person's  Full Name.", Description="FullName", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefOtherNameType Pick List
         /// </summary>
        public static List<RefOtherNameType> RefOtherNameTypePickList = new List<RefOtherNameType> =
        {
            new RefOtherNameType { Id=Guid.Parse("5ad0898a-c1a1-45cd-9b1d-3b447c83bf77"), Code="The value specified for Other Name is the person's Alias.", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("6fb7d2a7-8a75-4b54-8be4-67051fd7b733"), Code="The value specified for Other Name is the person's Nickname.", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("eb9e1e4b-498a-460f-af27-677e4fd0cf3d"), Code="The value specified for Other Name is the person's Other name.", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("e73e4728-4b7c-4c18-a793-46bbdcc7a185"), Code="The value specified for Other Name is the person's Previous legal name.", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("09378f3f-c8bc-4edc-a966-1eb4a3b61419"), Code="The value specified for Other Name is the person's Preferred Family Name.", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("196dc5be-cb6f-44ef-9ac3-a3a8315113ab"), Code="The value specified for Other Name is the person's Preferred Given Name.", SortOrder=0 },
            new RefOtherNameType { Id=Guid.Parse("911986c9-2b01-4e57-91fc-b4ded0accd9b"), Code="The value specified for Other Name is the person's  Full Name.", SortOrder=0 },
       };
   }
}
