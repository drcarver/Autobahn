//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceAccessHazardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceAccessHazardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceAccessHazardTypeModel"> List
         /// </summary>
        public static List<RefLearningResourceAccessHazardTypeModel> RefLearningResourceAccessHazardTypeList = new List<RefLearningResourceAccessHazardTypeModel>
        {
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("2eab2a59-9e8c-43ca-bb51-3c55661bb05e"), Code="Flashing", Description="Flashing", Definition="Flashing is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("0d74cdb6-70d2-4f79-969f-1931840f006d"), Code="MotionSimulation", Description="Motion simulation", Definition="Motion simulation is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("40261226-b874-4a25-b84a-50f97385e9b1"), Code="Sound", Description="Sound", Definition="Sound is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceAccessHazardType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceAccessHazardTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("2eab2a59-9e8c-43ca-bb51-3c55661bb05e"), Description="Flashing", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("0d74cdb6-70d2-4f79-969f-1931840f006d"), Description="Motion simulation", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("40261226-b874-4a25-b84a-50f97385e9b1"), Description="Sound", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
