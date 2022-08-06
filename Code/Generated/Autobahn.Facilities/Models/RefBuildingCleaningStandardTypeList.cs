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
        /// The complete <see cref="RefBuildingCleaningStandardType"> List
         /// </summary>
        public static List<RefBuildingCleaningStandardType> RefBuildingCleaningStandardTypeList = new List<RefBuildingCleaningStandardType>
        {
            new RefBuildingCleaningStandardType { Id=Guid.Parse("3a9cd890-4bcf-4dc4-82db-9d644a4d9206"), Code="02831", Description="Level 1 cleaning", Definition="`Spotless` cleaning, such as might be found in a hospital or corporate suite. One custodian, properly supplied and equipped, should be able to clean 10,000 square feet in an 8-hour period, depending upon the condition and level of utilization of the facility.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("6b763203-7a1b-4822-8943-628d7d2d5241"), Code="02832", Description="Level 2 cleaning", Definition="Intensive cleaning, reserved for areas such as restrooms, special education areas, kindergarten areas, or food service areas. One custodian, properly supplied and equipped, can clean approximately 11,000-18,000 square feet in an 8-hour period, depending upon the condition and level of utilization of the facility.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("442b2957-e239-426e-a18d-1fb90a220625"), Code="02833", Description="Level 3 cleaning", Definition="Cleaning required to ensure the health and comfort of building users. One custodian, properly supplied and equipped, should be able to clean 19,000-25,000 square feet of space in 8 hours to this standard, depending upon the condition and utilization of the facility.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("22993f48-368f-4a64-ab69-01a96b0e8b21"), Code="02834", Description="Level 4 cleaning", Definition="Not generally acceptable for a school environment. One custodian cleans 26,000-46,000 square feet in an 8-hour period.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("ef87d5ab-bc97-4268-ac4e-42765763215d"), Code="02835", Description="Level 5 cleaning", Definition="Not considered healthy. One custodian, even properly supplied and equipped, will not be able to clean 47,000-80,000 square feet in an 8-hour period, to a healthy standard, whatever the underlying condition or utilization of the facility.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefBuildingCleaningStandardType Pick List
         /// </summary>
        public static List<RefBuildingCleaningStandardType> RefBuildingCleaningStandardTypePickList = new List<RefBuildingCleaningStandardType>
        {
            new RefBuildingCleaningStandardType { Id=Guid.Parse("3a9cd890-4bcf-4dc4-82db-9d644a4d9206"), Code="02831", Description="Level 1 cleaning", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("6b763203-7a1b-4822-8943-628d7d2d5241"), Code="02832", Description="Level 2 cleaning", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("442b2957-e239-426e-a18d-1fb90a220625"), Code="02833", Description="Level 3 cleaning", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("22993f48-368f-4a64-ab69-01a96b0e8b21"), Code="02834", Description="Level 4 cleaning", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("ef87d5ab-bc97-4268-ac4e-42765763215d"), Code="02835", Description="Level 5 cleaning", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
