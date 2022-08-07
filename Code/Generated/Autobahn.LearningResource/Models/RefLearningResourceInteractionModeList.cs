//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceInteractionModeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceInteractionMode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceInteractionModeModel"> List
         /// </summary>
        public static List<RefLearningResourceInteractionModeModel> RefLearningResourceInteractionModeList = new List<RefLearningResourceInteractionModeModel>
        {
            new RefLearningResourceInteractionMode { Id=Guid.Parse("7ccd3bb0-9f0b-41c8-acc6-0128f86a95e7"), Code="Asynchronous", Description="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", Definition="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceInteractionMode { Id=Guid.Parse("652e6341-6c2d-436f-883d-2cc9e4713b22"), Code="Synchronous", Description="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", Definition="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceInteractionMode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceInteractionModeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceInteractionMode { Id=Guid.Parse("7ccd3bb0-9f0b-41c8-acc6-0128f86a95e7"), Description="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceInteractionMode { Id=Guid.Parse("652e6341-6c2d-436f-883d-2cc9e4713b22"), Description="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
