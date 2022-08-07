//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentAccommodationCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentAccommodationCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentAccommodationCategoryModel"> List
         /// </summary>
        public static List<RefAssessmentAccommodationCategoryModel> RefAssessmentAccommodationCategoryList = new List<RefAssessmentAccommodationCategoryModel>
        {
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("53c02b18-c469-4e8b-abf1-ce5b2421e05b"), Code="Scheduling", Description="Scheduling accommodations", Definition="Scheduling accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("6a3443e4-44c0-4fa8-aadb-d64c83a6c9bb"), Code="Setting", Description="Settings accommodations", Definition="Settings accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("89124177-6b68-4d9e-980c-cf71aaaf25d5"), Code="EquipmentOrTechnology", Description="Student equipment/technology", Definition="Student equipment/technology is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("61c169b2-8566-4cfa-805f-cf212737eea2"), Code="TestAdministration", Description="Test administration accommodation", Definition="Test administration accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8a9876e3-8fdf-4e53-8497-ca39adb36c18"), Code="TestMaterial", Description="Test material accommodations", Definition="Test material accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("6034938b-a217-4fb6-983a-d41f7c75a741"), Code="TestResponse", Description="Test response accommodation", Definition="Test response accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("eda72fd2-3dc1-40cb-9c8a-8f93ff1aa4cc"), Code="EnglishLearner", Description="English learner accommodation", Definition="English learner accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("e1fc89d6-a52e-4e9d-b01b-d699379a8df7"), Code="504", Description="504 accommodation", Definition="504 accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("e3d01ff3-35dd-442e-9c13-622e84caa018"), Code="Other", Description="Other", Definition="Others is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentAccommodationCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentAccommodationCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("53c02b18-c469-4e8b-abf1-ce5b2421e05b"), Description="Scheduling accommodations", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("6a3443e4-44c0-4fa8-aadb-d64c83a6c9bb"), Description="Settings accommodations", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("89124177-6b68-4d9e-980c-cf71aaaf25d5"), Description="Student equipment/technology", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("61c169b2-8566-4cfa-805f-cf212737eea2"), Description="Test administration accommodation", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8a9876e3-8fdf-4e53-8497-ca39adb36c18"), Description="Test material accommodations", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("6034938b-a217-4fb6-983a-d41f7c75a741"), Description="Test response accommodation", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("eda72fd2-3dc1-40cb-9c8a-8f93ff1aa4cc"), Description="English learner accommodation", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("e1fc89d6-a52e-4e9d-b01b-d699379a8df7"), Description="504 accommodation", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("e3d01ff3-35dd-442e-9c13-622e84caa018"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
