//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCourseInstructionSiteTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCourseInstructionSiteType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseInstructionSiteType"> List
         /// </summary>
        public static List<RefCourseInstructionSiteType> RefCourseInstructionSiteTypeList = new List<RefCourseInstructionSiteType>
        {
            new RefCourseInstructionSiteType { Id=Guid.Parse("a59bd4ea-52e1-4e9c-b762-a1532329e3aa"), Code="OnCampus", Description="On campus", Definition="On campus is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("ee7ccd8b-af71-4900-890e-74d75b8e71d9"), Code="OffCampus", Description="Off campus (e.g., branch campus, etc.)", Definition="Off campus (e.g., branch campus, etc.) is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("07aef30a-0728-4124-bd9a-b85900b3e185"), Code="Extension", Description="Extension center or site", Definition="Extension center or site is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("92f4e248-f044-4173-997a-1221070be778"), Code="StudyAbroad", Description="Study abroad", Definition="Study abroad is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("51f31d66-8e3b-458f-a8bf-8a4f1eea3c2d"), Code="Correctional", Description="Correctional institution", Definition="Correctional institution is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("fa942f62-1573-4e62-9a49-7478f8d916aa"), Code="Military", Description="Military Base", Definition="Military Base is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("9b75c087-9b52-44b4-9440-c9a718d883b6"), Code="Telecommunication", Description="Instructional telecommunications", Definition="Instructional telecommunications is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("b7cbf53f-1aa0-493d-bfec-b6eb1cfa8b08"), Code="Auxiliary", Description="Auxiliary", Definition="Auxiliary is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("19e2f089-8934-4ef0-9a94-a4c3f0daede9"), Code="ClinicHospital", Description="Clinic or hospital", Definition="Clinic or hospital is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The RefCourseInstructionSiteType Pick List
         /// </summary>
        public static List<RefCourseInstructionSiteType> RefCourseInstructionSiteTypePickList = new List<RefCourseInstructionSiteType>
        {
            new RefCourseInstructionSiteType { Id=Guid.Parse("a59bd4ea-52e1-4e9c-b762-a1532329e3aa"), Code="OnCampus", Description="On campus", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("ee7ccd8b-af71-4900-890e-74d75b8e71d9"), Code="OffCampus", Description="Off campus (e.g., branch campus, etc.)", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("07aef30a-0728-4124-bd9a-b85900b3e185"), Code="Extension", Description="Extension center or site", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("92f4e248-f044-4173-997a-1221070be778"), Code="StudyAbroad", Description="Study abroad", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("51f31d66-8e3b-458f-a8bf-8a4f1eea3c2d"), Code="Correctional", Description="Correctional institution", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("fa942f62-1573-4e62-9a49-7478f8d916aa"), Code="Military", Description="Military Base", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("9b75c087-9b52-44b4-9440-c9a718d883b6"), Code="Telecommunication", Description="Instructional telecommunications", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("b7cbf53f-1aa0-493d-bfec-b6eb1cfa8b08"), Code="Auxiliary", Description="Auxiliary", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("19e2f089-8934-4ef0-9a94-a4c3f0daede9"), Code="ClinicHospital", Description="Clinic or hospital", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
