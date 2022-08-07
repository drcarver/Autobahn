//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceInteractivityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceInteractivityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceInteractivityTypeModel"> List
         /// </summary>
        public static List<RefLearningResourceInteractivityTypeModel> RefLearningResourceInteractivityTypeList = new List<RefLearningResourceInteractivityTypeModel>
        {
            new RefLearningResourceInteractivityType { Id=Guid.Parse("799455ea-7cbe-42a3-b3c0-3c1db5b61f57"), Code="Active", Description="Active", Definition="The predominate mode of learning supported by the learning resource is: Active", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("45f993cb-a8e5-406d-a169-532334d092c8"), Code="Expositive", Description="Expositive", Definition="The predominate mode of learning supported by the learning resource is: Expositive", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("d19c6640-0a76-4d15-b5c4-369674939431"), Code="Mixed", Description="Mixed", Definition="The predominate mode of learning supported by the learning resource is: Mixed", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceInteractivityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceInteractivityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceInteractivityType { Id=Guid.Parse("799455ea-7cbe-42a3-b3c0-3c1db5b61f57"), Description="Active", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("45f993cb-a8e5-406d-a169-532334d092c8"), Description="Expositive", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("d19c6640-0a76-4d15-b5c4-369674939431"), Description="Mixed", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
