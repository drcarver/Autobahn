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
        /// The complete <see cref="RefAssessmentAccommodationCategory"> List
         /// </summary>
        public static List<RefAssessmentAccommodationCategory> RefAssessmentAccommodationCategoryList = new List<RefAssessmentAccommodationCategory>
        {
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("9d033f4a-d014-40a0-a9b0-8302ea81af4d"), Code="Scheduling", Description="Scheduling accommodations", Definition="Scheduling accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8e953133-2d71-4c35-b8f7-d10808c1bbbe"), Code="Setting", Description="Settings accommodations", Definition="Settings accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("4b33c0c4-8763-41d2-8222-8157385c052c"), Code="EquipmentOrTechnology", Description="Student equipment/technology", Definition="Student equipment/technology is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("5dd49ca2-a2e1-4d60-9b2b-5d6a345f2fe5"), Code="TestAdministration", Description="Test administration accommodation", Definition="Test administration accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8d057bc0-aaca-47f4-9a44-df46652cfc57"), Code="TestMaterial", Description="Test material accommodations", Definition="Test material accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("7af70e24-c8cb-4d3f-aea0-67fdf6f79f48"), Code="TestResponse", Description="Test response accommodation", Definition="Test response accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("54c79e49-4042-4884-ae59-19175ded47b3"), Code="EnglishLearner", Description="English learner accommodation", Definition="English learner accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("6af69d5e-0a6a-4304-9f5e-9ba126ad8bdf"), Code="504", Description="504 accommodation", Definition="504 accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8d6441de-a4a7-4016-9efe-caba3f318da1"), Code="Other", Description="Other", Definition="Others is specified as the category of accommodations needed for a given assessment.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefAssessmentAccommodationCategory Pick List
         /// </summary>
        public static List<RefAssessmentAccommodationCategory> RefAssessmentAccommodationCategoryPickList = new List<RefAssessmentAccommodationCategory>
        {
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("9d033f4a-d014-40a0-a9b0-8302ea81af4d"), Code="Scheduling", Description="Scheduling accommodations", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8e953133-2d71-4c35-b8f7-d10808c1bbbe"), Code="Setting", Description="Settings accommodations", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("4b33c0c4-8763-41d2-8222-8157385c052c"), Code="EquipmentOrTechnology", Description="Student equipment/technology", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("5dd49ca2-a2e1-4d60-9b2b-5d6a345f2fe5"), Code="TestAdministration", Description="Test administration accommodation", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8d057bc0-aaca-47f4-9a44-df46652cfc57"), Code="TestMaterial", Description="Test material accommodations", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("7af70e24-c8cb-4d3f-aea0-67fdf6f79f48"), Code="TestResponse", Description="Test response accommodation", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("54c79e49-4042-4884-ae59-19175ded47b3"), Code="EnglishLearner", Description="English learner accommodation", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("6af69d5e-0a6a-4304-9f5e-9ba126ad8bdf"), Code="504", Description="504 accommodation", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8d6441de-a4a7-4016-9efe-caba3f318da1"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
