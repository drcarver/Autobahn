//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceAuthorTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceAuthorType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceAuthorTypeModel"> List
         /// </summary>
        public static List<RefLearningResourceAuthorTypeModel> RefLearningResourceAuthorTypeList = new List<RefLearningResourceAuthorTypeModel>
        {
            new RefLearningResourceAuthorType { Id=Guid.Parse("abc5b29c-58b7-4a17-893f-e02aafb5d795"), Code="Organization", Description="Organization", Definition="The specified author of the learning resource is an organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceAuthorType { Id=Guid.Parse("e07888e3-ad05-49b5-801e-06a4ab96649d"), Code="Person", Description="Person", Definition="The specified author of the learning resource is a person.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceAuthorType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceAuthorTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceAuthorType { Id=Guid.Parse("abc5b29c-58b7-4a17-893f-e02aafb5d795"), Description="Organization", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceAuthorType { Id=Guid.Parse("e07888e3-ad05-49b5-801e-06a4ab96649d"), Description="Person", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
