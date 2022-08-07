//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceControlFlexibilityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceControlFlexibilityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceControlFlexibilityTypeModel"> List
         /// </summary>
        public static List<RefLearningResourceControlFlexibilityTypeModel> RefLearningResourceControlFlexibilityTypeList = new List<RefLearningResourceControlFlexibilityTypeModel>
        {
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("d97326d0-6c70-4c45-9e72-d9b5df948399"), Code="fullAudioControl", Description="Full Audio Control", Definition="Audio input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("13d8e9ad-d7e6-494b-a546-e94e3505e446"), Code="fullKeyboardControl", Description="Full Keyboard Control", Definition="Keyboard input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("be574101-05b5-48e5-946a-907e093aeff3"), Code="fullMouseControl", Description="Full Mouse Control", Definition="Mouse input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("53bec1cf-d141-4425-b219-c4a6e728a367"), Code="fullTouchControl", Description="Full Touch Control", Definition="Touch input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("f91980ea-f06a-4bc1-9d34-baee2d94a31c"), Code="fullVideoControl", Description="Full Video Control", Definition=" Video input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceControlFlexibilityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceControlFlexibilityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("d97326d0-6c70-4c45-9e72-d9b5df948399"), Description="Full Audio Control", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("13d8e9ad-d7e6-494b-a546-e94e3505e446"), Description="Full Keyboard Control", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("be574101-05b5-48e5-946a-907e093aeff3"), Description="Full Mouse Control", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("53bec1cf-d141-4425-b219-c4a6e728a367"), Description="Full Touch Control", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("f91980ea-f06a-4bc1-9d34-baee2d94a31c"), Description="Full Video Control", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
