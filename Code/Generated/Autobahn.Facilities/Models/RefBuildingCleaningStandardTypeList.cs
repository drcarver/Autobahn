//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCleaningStandardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingCleaningStandardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingCleaningStandardTypeModel"> List
         /// </summary>
        public static List<RefBuildingCleaningStandardTypeModel> RefBuildingCleaningStandardTypeList = new List<RefBuildingCleaningStandardTypeModel>
        {
            new RefBuildingCleaningStandardType { Id=Guid.Parse("125c84c0-5955-4b65-9108-08b161ffb59e"), Code="02831", Description="Level 1 cleaning", Definition="`Spotless` cleaning, such as might be found in a hospital or corporate suite. One custodian, properly supplied and equipped, should be able to clean 10,000 square feet in an 8-hour period, depending upon the condition and level of utilization of the facility.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("9a801067-38c1-485a-a3cd-9103591715f7"), Code="02832", Description="Level 2 cleaning", Definition="Intensive cleaning, reserved for areas such as restrooms, special education areas, kindergarten areas, or food service areas. One custodian, properly supplied and equipped, can clean approximately 11,000-18,000 square feet in an 8-hour period, depending upon the condition and level of utilization of the facility.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("36016062-8fd2-4f5c-8e72-74e33ffc4dd2"), Code="02833", Description="Level 3 cleaning", Definition="Cleaning required to ensure the health and comfort of building users. One custodian, properly supplied and equipped, should be able to clean 19,000-25,000 square feet of space in 8 hours to this standard, depending upon the condition and utilization of the facility.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("27ca58c1-730a-4c7d-8ee0-f2d10aeece2b"), Code="02834", Description="Level 4 cleaning", Definition="Not generally acceptable for a school environment. One custodian cleans 26,000-46,000 square feet in an 8-hour period.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("20624b29-5e7d-4c28-be82-8c76d8b2f934"), Code="02835", Description="Level 5 cleaning", Definition="Not considered healthy. One custodian, even properly supplied and equipped, will not be able to clean 47,000-80,000 square feet in an 8-hour period, to a healthy standard, whatever the underlying condition or utilization of the facility.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefBuildingCleaningStandardType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingCleaningStandardTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingCleaningStandardType { Id=Guid.Parse("125c84c0-5955-4b65-9108-08b161ffb59e"), Description="Level 1 cleaning", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("9a801067-38c1-485a-a3cd-9103591715f7"), Description="Level 2 cleaning", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("36016062-8fd2-4f5c-8e72-74e33ffc4dd2"), Description="Level 3 cleaning", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("27ca58c1-730a-4c7d-8ee0-f2d10aeece2b"), Description="Level 4 cleaning", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("20624b29-5e7d-4c28-be82-8c76d8b2f934"), Description="Level 5 cleaning", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
