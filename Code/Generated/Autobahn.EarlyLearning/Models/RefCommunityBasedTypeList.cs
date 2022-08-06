//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefCommunityBasedTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefCommunityBasedType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCommunityBasedType"> List
         /// </summary>
        public static List<RefCommunityBasedType> RefCommunityBasedTypeList = new List<RefCommunityBasedType> =
        {
            new RefCommunityBasedType { Id=Guid.Parse("9256f4ba-c62b-406c-88e1-0f66a132effb"), Code="Library is specified as the non domestic residence in which the early learning setting is located.", Description="Library", Definition="", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("2c912fd3-9f8d-46f4-866c-ff2120c72ed8"), Code="School is specified as the non domestic residence in which the early learning setting is located.", Description="School", Definition="", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("3e4725e2-c2a1-40e7-8754-e013617fc14a"), Code="Child development center is specified as the non domestic residence in which the early learning setting is located.", Description="ChildDevelopmentCenter", Definition="", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("a1f0002d-4dce-4128-ae86-6e387b6555c7"), Code="Hospital is specified as the non domestic residence in which the early learning setting is located.", Description="Hospital", Definition="", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("548aef98-ad5f-432b-bd19-24570fbff0e5"), Code="Public K12 School is specified as the non domestic residence in which the early learning setting is located.", Description="PublicK12School", Definition="", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("5050b8b2-2a6b-4c97-b07a-fff415fa12d1"), Code="University is specified as the non domestic residence in which the early learning setting is located.", Description="University", Definition="", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("5c1ea7cc-df83-428b-b376-31914bcf3c5f"), Code="Other is specified as the non domestic residence in which the early learning setting is located.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCommunityBasedType Pick List
         /// </summary>
        public static List<RefCommunityBasedType> RefCommunityBasedTypePickList = new List<RefCommunityBasedType> =
        {
            new RefCommunityBasedType { Id=Guid.Parse("9256f4ba-c62b-406c-88e1-0f66a132effb"), Code="Library is specified as the non domestic residence in which the early learning setting is located.", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("2c912fd3-9f8d-46f4-866c-ff2120c72ed8"), Code="School is specified as the non domestic residence in which the early learning setting is located.", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("3e4725e2-c2a1-40e7-8754-e013617fc14a"), Code="Child development center is specified as the non domestic residence in which the early learning setting is located.", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("a1f0002d-4dce-4128-ae86-6e387b6555c7"), Code="Hospital is specified as the non domestic residence in which the early learning setting is located.", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("548aef98-ad5f-432b-bd19-24570fbff0e5"), Code="Public K12 School is specified as the non domestic residence in which the early learning setting is located.", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("5050b8b2-2a6b-4c97-b07a-fff415fa12d1"), Code="University is specified as the non domestic residence in which the early learning setting is located.", SortOrder=0 },
            new RefCommunityBasedType { Id=Guid.Parse("5c1ea7cc-df83-428b-b376-31914bcf3c5f"), Code="Other is specified as the non domestic residence in which the early learning setting is located.", SortOrder=0 },
       };
   }
}
