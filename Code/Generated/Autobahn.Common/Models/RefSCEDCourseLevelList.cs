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
        public static List<RefSCEDCourseLevel> RefSCEDCourseLevelList = new List<RefSCEDCourseLevel> =
        {
            new RefSCEDCourseLevel { Id=Guid.Parse("4dc71ad3-ceb1-4dc7-828b-c1bf4983537d"), Code="The course's level of rigor is basic or remedial.", Description="B", Definition="", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("f8e7fb01-f10e-439f-aa25-e4f6caed9219"), Code="The course's level of rigor is enriched or advanced.", Description="E", Definition="", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("b957814c-fd04-4c09-a7ba-3cd28cb7b221"), Code="The course's level of rigor is general or regular.", Description="G", Definition="", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("a514e115-5a60-4a96-b995-fb3f442c6622"), Code="The course's level of rigor is honors.", Description="H", Definition="", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("7c07d15c-5eab-4a02-9240-a7d905bbbb6c"), Code="The course's level of rigor is college.", Description="C", Definition="", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("435cb6fd-d94b-4430-a150-08a2c8517e9a"), Code="The course has no specified level of rigor.", Description="X", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefSCEDCourseLevel Pick List
         /// </summary>
        public static List<RefSCEDCourseLevel> RefSCEDCourseLevelPickList = new List<RefSCEDCourseLevel> =
        {
            new RefSCEDCourseLevel { Id=Guid.Parse("4dc71ad3-ceb1-4dc7-828b-c1bf4983537d"), Code="The course's level of rigor is basic or remedial.", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("f8e7fb01-f10e-439f-aa25-e4f6caed9219"), Code="The course's level of rigor is enriched or advanced.", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("b957814c-fd04-4c09-a7ba-3cd28cb7b221"), Code="The course's level of rigor is general or regular.", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("a514e115-5a60-4a96-b995-fb3f442c6622"), Code="The course's level of rigor is honors.", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("7c07d15c-5eab-4a02-9240-a7d905bbbb6c"), Code="The course's level of rigor is college.", SortOrder=0 },
            new RefSCEDCourseLevel { Id=Guid.Parse("435cb6fd-d94b-4430-a150-08a2c8517e9a"), Code="The course has no specified level of rigor.", SortOrder=0 },
       };
   }
}
