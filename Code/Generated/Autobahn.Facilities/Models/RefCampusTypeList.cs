//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefCampusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefCampusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCampusType"> List
         /// </summary>
        public static List<RefCampusType> RefCampusTypeList = new List<RefCampusType> =
        {
            new RefCampusType { Id=Guid.Parse("cc7876f8-7313-4e3f-a8b6-8b9828eb2dbd"), Code="Administration is specified as the primary purpose for which a campus is designed and/or used.", Description="Administration", Definition="", SortOrder=0 },
            new RefCampusType { Id=Guid.Parse("d69c4dc2-0fbf-4cb6-b0f7-2782cacd9f89"), Code="Education is specified as the primary purpose for which a campus is designed and/or used.", Description="Education", Definition="", SortOrder=0 },
            new RefCampusType { Id=Guid.Parse("6dc72acd-ae17-47b1-993d-db9d4a784da2"), Code="Operations is specified as the primary purpose for which a campus is designed and/or used.", Description="Operations", Definition="", SortOrder=0 },
            new RefCampusType { Id=Guid.Parse("5c4f38c6-4c5a-497f-9117-f1d8033748bd"), Code="Residential is specified as the primary purpose for which a campus is designed and/or used.", Description="Residential", Definition="", SortOrder=0 },
            new RefCampusType { Id=Guid.Parse("64f96fe5-d2af-42f1-b048-2146e2f2b6de"), Code="Other is specified as the primary purpose for which a campus is designed and/or used.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCampusType Pick List
         /// </summary>
        public static List<RefCampusType> RefCampusTypePickList = new List<RefCampusType> =
        {
            new RefCampusType { Id=Guid.Parse("cc7876f8-7313-4e3f-a8b6-8b9828eb2dbd"), Code="Administration is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=0 },
            new RefCampusType { Id=Guid.Parse("d69c4dc2-0fbf-4cb6-b0f7-2782cacd9f89"), Code="Education is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=0 },
            new RefCampusType { Id=Guid.Parse("6dc72acd-ae17-47b1-993d-db9d4a784da2"), Code="Operations is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=0 },
            new RefCampusType { Id=Guid.Parse("5c4f38c6-4c5a-497f-9117-f1d8033748bd"), Code="Residential is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=0 },
            new RefCampusType { Id=Guid.Parse("64f96fe5-d2af-42f1-b048-2146e2f2b6de"), Code="Other is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=0 },
       };
   }
}
