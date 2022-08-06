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
        public static List<RefBuildingCleaningStandardType> RefBuildingCleaningStandardTypeList = new List<RefBuildingCleaningStandardType> =
        {
            new RefBuildingCleaningStandardType { Id=Guid.Parse("55cedd35-defb-4c8e-9abc-93c329cb812c"), Code="`Spotless` cleaning, such as might be found in a hospital or corporate suite. One custodian, properly supplied and equipped, should be able to clean 10,000 square feet in an 8-hour period, depending upon the condition and level of utilization of the facility.", Description="02831", Definition="", SortOrder=0 },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("7cdbe959-3acb-4ab1-bdb9-04c297f97bde"), Code="Intensive cleaning, reserved for areas such as restrooms, special education areas, kindergarten areas, or food service areas. One custodian, properly supplied and equipped, can clean approximately 11,000-18,000 square feet in an 8-hour period, depending upon the condition and level of utilization of the facility.", Description="02832", Definition="", SortOrder=0 },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("4b401290-f127-46c0-8fdf-651e8ced7ce6"), Code="Cleaning required to ensure the health and comfort of building users. One custodian, properly supplied and equipped, should be able to clean 19,000-25,000 square feet of space in 8 hours to this standard, depending upon the condition and utilization of the facility.", Description="02833", Definition="", SortOrder=0 },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("a816d7a9-4e4a-45ea-9047-ceb9cb5096de"), Code="Not generally acceptable for a school environment. One custodian cleans 26,000-46,000 square feet in an 8-hour period.", Description="02834", Definition="", SortOrder=0 },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("bf9805c9-9380-43ce-94c8-99757b3e146e"), Code="Not considered healthy. One custodian, even properly supplied and equipped, will not be able to clean 47,000-80,000 square feet in an 8-hour period, to a healthy standard, whatever the underlying condition or utilization of the facility.", Description="02835", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingCleaningStandardType Pick List
         /// </summary>
        public static List<RefBuildingCleaningStandardType> RefBuildingCleaningStandardTypePickList = new List<RefBuildingCleaningStandardType> =
        {
            new RefBuildingCleaningStandardType { Id=Guid.Parse("55cedd35-defb-4c8e-9abc-93c329cb812c"), Code="`Spotless` cleaning, such as might be found in a hospital or corporate suite. One custodian, properly supplied and equipped, should be able to clean 10,000 square feet in an 8-hour period, depending upon the condition and level of utilization of the facility.", SortOrder=0 },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("7cdbe959-3acb-4ab1-bdb9-04c297f97bde"), Code="Intensive cleaning, reserved for areas such as restrooms, special education areas, kindergarten areas, or food service areas. One custodian, properly supplied and equipped, can clean approximately 11,000-18,000 square feet in an 8-hour period, depending upon the condition and level of utilization of the facility.", SortOrder=0 },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("4b401290-f127-46c0-8fdf-651e8ced7ce6"), Code="Cleaning required to ensure the health and comfort of building users. One custodian, properly supplied and equipped, should be able to clean 19,000-25,000 square feet of space in 8 hours to this standard, depending upon the condition and utilization of the facility.", SortOrder=0 },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("a816d7a9-4e4a-45ea-9047-ceb9cb5096de"), Code="Not generally acceptable for a school environment. One custodian cleans 26,000-46,000 square feet in an 8-hour period.", SortOrder=0 },
            new RefBuildingCleaningStandardType { Id=Guid.Parse("bf9805c9-9380-43ce-94c8-99757b3e146e"), Code="Not considered healthy. One custodian, even properly supplied and equipped, will not be able to clean 47,000-80,000 square feet in an 8-hour period, to a healthy standard, whatever the underlying condition or utilization of the facility.", SortOrder=0 },
       };
   }
}
