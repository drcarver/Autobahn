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
        public static List<RefCommunityBasedType> RefCommunityBasedTypeList = new List<RefCommunityBasedType>
        {
            new RefCommunityBasedType { Id=Guid.Parse("c3a6a6c6-cf57-4b60-81e3-646b76cbb682"), Code="Library", Description="Library", Definition="Library is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCommunityBasedType { Id=Guid.Parse("3c3df694-6c56-4c84-b812-12b043df5468"), Code="School", Description="School", Definition="School is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCommunityBasedType { Id=Guid.Parse("70b0794b-5e6d-4631-83b8-761d239c1e1a"), Code="ChildDevelopmentCenter", Description="Child development center", Definition="Child development center is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCommunityBasedType { Id=Guid.Parse("583c86b3-e686-428e-bbca-431aad5bb542"), Code="Hospital", Description="Hospital", Definition="Hospital is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCommunityBasedType { Id=Guid.Parse("5c2435c6-baec-47bd-8ae2-a3cf7c5541f9"), Code="PublicK12School", Description="Public K12 School", Definition="Public K12 School is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("9.00") },
            new RefCommunityBasedType { Id=Guid.Parse("e6aafb49-7130-47d9-8e42-cf4d272e5e1b"), Code="University", Description="University", Definition="University is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("11.00") },
            new RefCommunityBasedType { Id=Guid.Parse("e5bab487-7a25-447d-8c93-5a775e02dee6"), Code="Other", Description="Other", Definition="Other is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefCommunityBasedType Pick List
         /// </summary>
        public static List<RefCommunityBasedType> RefCommunityBasedTypePickList = new List<RefCommunityBasedType>
        {
            new RefCommunityBasedType { Id=Guid.Parse("c3a6a6c6-cf57-4b60-81e3-646b76cbb682"), Code="Library", Description="Library", SortOrder=Convert.ToDecimal("1.00") },
            new RefCommunityBasedType { Id=Guid.Parse("3c3df694-6c56-4c84-b812-12b043df5468"), Code="School", Description="School", SortOrder=Convert.ToDecimal("3.00") },
            new RefCommunityBasedType { Id=Guid.Parse("70b0794b-5e6d-4631-83b8-761d239c1e1a"), Code="ChildDevelopmentCenter", Description="Child development center", SortOrder=Convert.ToDecimal("5.00") },
            new RefCommunityBasedType { Id=Guid.Parse("583c86b3-e686-428e-bbca-431aad5bb542"), Code="Hospital", Description="Hospital", SortOrder=Convert.ToDecimal("7.00") },
            new RefCommunityBasedType { Id=Guid.Parse("5c2435c6-baec-47bd-8ae2-a3cf7c5541f9"), Code="PublicK12School", Description="Public K12 School", SortOrder=Convert.ToDecimal("9.00") },
            new RefCommunityBasedType { Id=Guid.Parse("e6aafb49-7130-47d9-8e42-cf4d272e5e1b"), Code="University", Description="University", SortOrder=Convert.ToDecimal("11.00") },
            new RefCommunityBasedType { Id=Guid.Parse("e5bab487-7a25-447d-8c93-5a775e02dee6"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
