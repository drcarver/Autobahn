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
        /// The complete <see cref="RefCourseInstructionSiteTypeModel"> List
         /// </summary>
        public static List<RefCourseInstructionSiteTypeModel> RefCourseInstructionSiteTypeList = new List<RefCourseInstructionSiteTypeModel>
        {
            new RefCourseInstructionSiteType { Id=Guid.Parse("6fc8efa4-738a-4e34-ac18-6cf49524aaa1"), Code="OnCampus", Description="On campus", Definition="On campus is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("98c3c4a3-65cc-4a7e-9983-57fea40f4795"), Code="OffCampus", Description="Off campus (e.g., branch campus, etc.)", Definition="Off campus (e.g., branch campus, etc.) is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("8bb8321e-8f26-4f88-83fb-a19f4705de6c"), Code="Extension", Description="Extension center or site", Definition="Extension center or site is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("84f432fc-e5dc-4735-ac72-fbfa81f1bdf7"), Code="StudyAbroad", Description="Study abroad", Definition="Study abroad is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("3201ddb0-0ff4-4291-9f94-649941b57b37"), Code="Correctional", Description="Correctional institution", Definition="Correctional institution is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("5681665d-8769-4372-9804-aba034e23514"), Code="Military", Description="Military Base", Definition="Military Base is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("50a7a3a5-3e65-4a9b-91b9-e16a92aedac4"), Code="Telecommunication", Description="Instructional telecommunications", Definition="Instructional telecommunications is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("54ee5955-12d2-4a4e-ac81-7d40de420632"), Code="Auxiliary", Description="Auxiliary", Definition="Auxiliary is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("4e694364-d3c9-461f-8b0b-4e37858c8f7c"), Code="ClinicHospital", Description="Clinic or hospital", Definition="Clinic or hospital is specified as the type of location at which the course is taught.", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The Reference RefCourseInstructionSiteType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseInstructionSiteTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseInstructionSiteType { Id=Guid.Parse("6fc8efa4-738a-4e34-ac18-6cf49524aaa1"), Description="On campus", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("98c3c4a3-65cc-4a7e-9983-57fea40f4795"), Description="Off campus (e.g., branch campus, etc.)", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("8bb8321e-8f26-4f88-83fb-a19f4705de6c"), Description="Extension center or site", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("84f432fc-e5dc-4735-ac72-fbfa81f1bdf7"), Description="Study abroad", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("3201ddb0-0ff4-4291-9f94-649941b57b37"), Description="Correctional institution", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("5681665d-8769-4372-9804-aba034e23514"), Description="Military Base", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("50a7a3a5-3e65-4a9b-91b9-e16a92aedac4"), Description="Instructional telecommunications", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("54ee5955-12d2-4a4e-ac81-7d40de420632"), Description="Auxiliary", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseInstructionSiteType { Id=Guid.Parse("4e694364-d3c9-461f-8b0b-4e37858c8f7c"), Description="Clinic or hospital", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
