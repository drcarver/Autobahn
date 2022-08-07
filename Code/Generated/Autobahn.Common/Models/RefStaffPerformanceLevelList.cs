//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefStaffPerformanceLevelList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefStaffPerformanceLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStaffPerformanceLevelModel"> List
         /// </summary>
        public static List<RefStaffPerformanceLevelModel> RefStaffPerformanceLevelList = new List<RefStaffPerformanceLevelModel>
        {
            new RefStaffPerformanceLevel { Id=Guid.Parse("25014589-994a-4652-a886-c04df5e8a9fb"), Code="FAL1", Description="Level 1 (lowest level)", Definition="Level 1 (lowest level) is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("4a773490-2c45-4e82-bfc8-35e9bb47df1c"), Code="FAL2", Description="Level 2", Definition="Level 2 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("f773d879-7546-41b9-b8dc-89c0fcace390"), Code="FAL3", Description="Level 3", Definition="Level 3 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("3.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("84853c31-049a-4b2f-b6d5-7ba27ebf85bc"), Code="FAL4", Description="Level 4", Definition="Level 4 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("4.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("aec0f524-78d1-43a3-b36c-2cbe53246a9e"), Code="FAL5", Description="Level 5", Definition="Level 5 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("5.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("ea7f19d2-371e-479a-8d53-5edff95acfd5"), Code="FAL6", Description="Level 6 (highest level)", Definition="Level 6 (highest level) is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("6.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("c3874a00-11c7-4a85-b7b6-5af38f69d128"), Code="EVALNR", Description="Evaluated, not ranked", Definition="Evaluated, not ranked is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefStaffPerformanceLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefStaffPerformanceLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefStaffPerformanceLevel { Id=Guid.Parse("25014589-994a-4652-a886-c04df5e8a9fb"), Description="Level 1 (lowest level)", SortOrder=Convert.ToDecimal("1.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("4a773490-2c45-4e82-bfc8-35e9bb47df1c"), Description="Level 2", SortOrder=Convert.ToDecimal("2.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("f773d879-7546-41b9-b8dc-89c0fcace390"), Description="Level 3", SortOrder=Convert.ToDecimal("3.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("84853c31-049a-4b2f-b6d5-7ba27ebf85bc"), Description="Level 4", SortOrder=Convert.ToDecimal("4.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("aec0f524-78d1-43a3-b36c-2cbe53246a9e"), Description="Level 5", SortOrder=Convert.ToDecimal("5.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("ea7f19d2-371e-479a-8d53-5edff95acfd5"), Description="Level 6 (highest level)", SortOrder=Convert.ToDecimal("6.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("c3874a00-11c7-4a85-b7b6-5af38f69d128"), Description="Evaluated, not ranked", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
