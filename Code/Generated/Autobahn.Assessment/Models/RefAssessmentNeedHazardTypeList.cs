//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedHazardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedHazardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedHazardTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedHazardTypeModel> RefAssessmentNeedHazardTypeList = new List<RefAssessmentNeedHazardTypeModel>
        {
            new RefAssessmentNeedHazardType { Id=Guid.Parse("08f20cac-5bb3-4df4-8caa-88747b3d9c5c"), Code="Flashing", Description="Flashing", Definition="Flashing is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("130c3312-9d8b-4bb3-b8ad-b1070ea0ed4a"), Code="Sound", Description="Sound", Definition="Sound is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("8a065d4e-3ea3-47d6-820a-7a99bdaa4df2"), Code="Olfactory", Description="Olfactory", Definition="Olfactory is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("b9c2c938-8b7c-4e47-a420-58878c524dc2"), Code="MotionSimulation", Description="Motion simulation", Definition="Motion simulation is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedHazardType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedHazardTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedHazardType { Id=Guid.Parse("08f20cac-5bb3-4df4-8caa-88747b3d9c5c"), Description="Flashing", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("130c3312-9d8b-4bb3-b8ad-b1070ea0ed4a"), Description="Sound", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("8a065d4e-3ea3-47d6-820a-7a99bdaa4df2"), Description="Olfactory", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("b9c2c938-8b7c-4e47-a420-58878c524dc2"), Description="Motion simulation", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
