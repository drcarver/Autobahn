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
        public static List<RefAssessmentAccommodationCategory> RefAssessmentAccommodationCategoryList = new List<RefAssessmentAccommodationCategory> =
        {
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("db4c99d5-5182-4e01-bad7-d2cf5b76c997"), Code="Scheduling accommodations is specified as the category of accommodations needed for a given assessment.", Description="Scheduling", Definition="", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("14626300-a184-4e39-8b1b-27345534bf2d"), Code="Settings accommodations is specified as the category of accommodations needed for a given assessment.", Description="Setting", Definition="", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("09cc0b46-c3b0-4327-aa6c-7c239b0ed09a"), Code="Student equipment/technology is specified as the category of accommodations needed for a given assessment.", Description="EquipmentOrTechnology", Definition="", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("da668245-d6ea-44d1-8e6a-a1ca1c603fe5"), Code="Test administration accommodations is specified as the category of accommodations needed for a given assessment.", Description="TestAdministration", Definition="", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("04a56f26-4f92-437b-9d7b-5e47ac7d50d2"), Code="Test material accommodations is specified as the category of accommodations needed for a given assessment.", Description="TestMaterial", Definition="", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("65815d4e-60c3-45ab-a0a0-30ce509110b7"), Code="Test response accommodations is specified as the category of accommodations needed for a given assessment.", Description="TestResponse", Definition="", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("9515b15c-5442-4fca-99bd-b6617c3030be"), Code="English learner accommodations is specified as the category of accommodations needed for a given assessment.", Description="EnglishLearner", Definition="", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8a123a3c-bc59-4f87-9355-27a4235d3944"), Code="504 accommodations is specified as the category of accommodations needed for a given assessment.", Description="504", Definition="", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("241fcbe2-5352-4874-9463-aa89f58ca1ff"), Code="Others is specified as the category of accommodations needed for a given assessment.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentAccommodationCategory Pick List
         /// </summary>
        public static List<RefAssessmentAccommodationCategory> RefAssessmentAccommodationCategoryPickList = new List<RefAssessmentAccommodationCategory> =
        {
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("db4c99d5-5182-4e01-bad7-d2cf5b76c997"), Code="Scheduling accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("14626300-a184-4e39-8b1b-27345534bf2d"), Code="Settings accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("09cc0b46-c3b0-4327-aa6c-7c239b0ed09a"), Code="Student equipment/technology is specified as the category of accommodations needed for a given assessment.", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("da668245-d6ea-44d1-8e6a-a1ca1c603fe5"), Code="Test administration accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("04a56f26-4f92-437b-9d7b-5e47ac7d50d2"), Code="Test material accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("65815d4e-60c3-45ab-a0a0-30ce509110b7"), Code="Test response accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("9515b15c-5442-4fca-99bd-b6617c3030be"), Code="English learner accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("8a123a3c-bc59-4f87-9355-27a4235d3944"), Code="504 accommodations is specified as the category of accommodations needed for a given assessment.", SortOrder=0 },
            new RefAssessmentAccommodationCategory { Id=Guid.Parse("241fcbe2-5352-4874-9463-aa89f58ca1ff"), Code="Others is specified as the category of accommodations needed for a given assessment.", SortOrder=0 },
       };
   }
}
