//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSCEDCourseLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSCEDCourseLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSCEDCourseLevel"> List
         /// </summary>
        public static List<RefSCEDCourseLevel> RefSCEDCourseLevelList = new List<RefSCEDCourseLevel>
        {
            new RefSCEDCourseLevel { Id=Guid.Parse("80210ff3-c9ea-4723-a878-05466a4dcd2f"), Code="B", Description="Basic or remedial", Definition="The course's level of rigor is basic or remedial.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("328ff872-0dea-4f99-9efe-52c8762e93fb"), Code="E", Description="Enriched or advanced", Definition="The course's level of rigor is enriched or advanced.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("f9766ed8-f5a9-41b8-b57e-644593155669"), Code="G", Description="General or regular", Definition="The course's level of rigor is general or regular.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("92d35792-49b3-42f6-9314-c69ba5c3a984"), Code="H", Description="Honors", Definition="The course's level of rigor is honors.", SortOrder=Convert.ToDecimal("8.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("717a74c8-05d3-43f4-a35c-3584eda4afc1"), Code="C", Description="College", Definition="The course's level of rigor is college.", SortOrder=Convert.ToDecimal("10.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("bab02569-f280-4191-a961-ea42695b17f3"), Code="X", Description="No specified level of rigor", Definition="The course has no specified level of rigor.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The RefSCEDCourseLevel Pick List
         /// </summary>
        public static List<RefSCEDCourseLevel> RefSCEDCourseLevelPickList = new List<RefSCEDCourseLevel>
        {
            new RefSCEDCourseLevel { Id=Guid.Parse("80210ff3-c9ea-4723-a878-05466a4dcd2f"), Code="B", Description="Basic or remedial", SortOrder=Convert.ToDecimal("2.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("328ff872-0dea-4f99-9efe-52c8762e93fb"), Code="E", Description="Enriched or advanced", SortOrder=Convert.ToDecimal("4.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("f9766ed8-f5a9-41b8-b57e-644593155669"), Code="G", Description="General or regular", SortOrder=Convert.ToDecimal("6.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("92d35792-49b3-42f6-9314-c69ba5c3a984"), Code="H", Description="Honors", SortOrder=Convert.ToDecimal("8.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("717a74c8-05d3-43f4-a35c-3584eda4afc1"), Code="C", Description="College", SortOrder=Convert.ToDecimal("10.00") },
            new RefSCEDCourseLevel { Id=Guid.Parse("bab02569-f280-4191-a961-ea42695b17f3"), Code="X", Description="No specified level of rigor", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
