//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSCEDCourseLevelList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSCEDCourseLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSCEDCourseLevelModel"> List
         /// </summary>
        public static List<RefSCEDCourseLevelModel> RefSCEDCourseLevelList = new List<RefSCEDCourseLevelModel>
        {
            new RefSCEDCourseLevel { Id=Guid.Parse("4e166ea0-a7a2-439a-9d5f-c6f555a5a058"), Code="B", Description="Basic or remedial", Definition="The course's level of rigor is basic or remedial.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("e08eccff-2243-429b-bb5b-51d1b6e5a928"), Code="E", Description="Enriched or advanced", Definition="The course's level of rigor is enriched or advanced.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("04c160cd-003e-4bb9-99f6-2e76b620ff3d"), Code="G", Description="General or regular", Definition="The course's level of rigor is general or regular.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("ad31ead2-118f-47b5-a92a-f5ccd0943555"), Code="H", Description="Honors", Definition="The course's level of rigor is honors.", SortOrder=Convert.ToDecimal("8.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("c75fd9d2-30d8-4fd5-86a4-1e41ad997c5e"), Code="C", Description="College", Definition="The course's level of rigor is college.", SortOrder=Convert.ToDecimal("10.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("7e007e2a-1897-4f45-a2c9-541dd73f5761"), Code="X", Description="No specified level of rigor", Definition="The course has no specified level of rigor.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefSCEDCourseLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSCEDCourseLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSCEDCourseLevel { Id=Guid.Parse("4e166ea0-a7a2-439a-9d5f-c6f555a5a058"), Description="Basic or remedial", SortOrder=Convert.ToDecimal("2.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("e08eccff-2243-429b-bb5b-51d1b6e5a928"), Description="Enriched or advanced", SortOrder=Convert.ToDecimal("4.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("04c160cd-003e-4bb9-99f6-2e76b620ff3d"), Description="General or regular", SortOrder=Convert.ToDecimal("6.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("ad31ead2-118f-47b5-a92a-f5ccd0943555"), Description="Honors", SortOrder=Convert.ToDecimal("8.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("c75fd9d2-30d8-4fd5-86a4-1e41ad997c5e"), Description="College", SortOrder=Convert.ToDecimal("10.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("7e007e2a-1897-4f45-a2c9-541dd73f5761"), Description="No specified level of rigor", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
