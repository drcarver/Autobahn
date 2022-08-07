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
        /// The complete <see cref="RefCommunityBasedTypeModel"> List
         /// </summary>
        public static List<RefCommunityBasedTypeModel> RefCommunityBasedTypeList = new List<RefCommunityBasedTypeModel>
        {
            new RefCommunityBasedType { Id=Guid.Parse("111be01e-658d-4432-9732-4a470de3b3f3"), Code="Library", Description="Library", Definition="Library is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCommunityBasedType { Id=Guid.Parse("a28ae7c8-b211-41f7-bac6-5ffb5243e0ac"), Code="School", Description="School", Definition="School is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCommunityBasedType { Id=Guid.Parse("d58ca9c0-e6a9-4fb7-b694-04bdb8525e1d"), Code="ChildDevelopmentCenter", Description="Child development center", Definition="Child development center is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCommunityBasedType { Id=Guid.Parse("91732dd8-6303-4ca4-89e9-e4e5623d5845"), Code="Hospital", Description="Hospital", Definition="Hospital is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCommunityBasedType { Id=Guid.Parse("6ff79727-8013-4633-8c12-72d87355f652"), Code="PublicK12School", Description="Public K12 School", Definition="Public K12 School is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("9.00") },
            new RefCommunityBasedType { Id=Guid.Parse("bca1729f-61db-4b5c-9277-4e31be482621"), Code="University", Description="University", Definition="University is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("11.00") },
            new RefCommunityBasedType { Id=Guid.Parse("793f1ea0-d1c8-46f3-af31-8eb4c3ccbf4d"), Code="Other", Description="Other", Definition="Other is specified as the non domestic residence in which the early learning setting is located.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefCommunityBasedType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCommunityBasedTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCommunityBasedType { Id=Guid.Parse("111be01e-658d-4432-9732-4a470de3b3f3"), Description="Library", SortOrder=Convert.ToDecimal("1.00") },
            new RefCommunityBasedType { Id=Guid.Parse("a28ae7c8-b211-41f7-bac6-5ffb5243e0ac"), Description="School", SortOrder=Convert.ToDecimal("3.00") },
            new RefCommunityBasedType { Id=Guid.Parse("d58ca9c0-e6a9-4fb7-b694-04bdb8525e1d"), Description="Child development center", SortOrder=Convert.ToDecimal("5.00") },
            new RefCommunityBasedType { Id=Guid.Parse("91732dd8-6303-4ca4-89e9-e4e5623d5845"), Description="Hospital", SortOrder=Convert.ToDecimal("7.00") },
            new RefCommunityBasedType { Id=Guid.Parse("6ff79727-8013-4633-8c12-72d87355f652"), Description="Public K12 School", SortOrder=Convert.ToDecimal("9.00") },
            new RefCommunityBasedType { Id=Guid.Parse("bca1729f-61db-4b5c-9277-4e31be482621"), Description="University", SortOrder=Convert.ToDecimal("11.00") },
            new RefCommunityBasedType { Id=Guid.Parse("793f1ea0-d1c8-46f3-af31-8eb4c3ccbf4d"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
