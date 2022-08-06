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
        public static List<RefCourseInstructionSiteType> RefCourseInstructionSiteTypeList = new List<RefCourseInstructionSiteType> =
        {
            new RefCourseInstructionSiteType { Id=Guid.Parse("8dd28c74-a869-46dc-bdb9-52726b2350aa"), Code="On campus is specified as the type of location at which the course is taught.", Description="OnCampus", Definition="", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("8951df0b-36b5-4da8-9f69-061e016e1d74"), Code="Off campus (e.g., branch campus, etc.) is specified as the type of location at which the course is taught.", Description="OffCampus", Definition="", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("61ed6ccf-722c-4ec1-a161-a1ed1662dfd1"), Code="Extension center or site is specified as the type of location at which the course is taught.", Description="Extension", Definition="", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("e848c1eb-7bc8-4f4a-bbd7-2b82562c3f4b"), Code="Study abroad is specified as the type of location at which the course is taught.", Description="StudyAbroad", Definition="", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("70ef5dfb-4385-4955-a25d-60acaca28618"), Code="Correctional institution is specified as the type of location at which the course is taught.", Description="Correctional", Definition="", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("43ba3f58-cd87-4ba2-bee7-bed79afb2480"), Code="Military Base is specified as the type of location at which the course is taught.", Description="Military", Definition="", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("118af976-a343-42c3-ba0b-542ca7412d9c"), Code="Instructional telecommunications is specified as the type of location at which the course is taught.", Description="Telecommunication", Definition="", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("0495827e-3946-41dc-8a4b-1892973d484f"), Code="Auxiliary is specified as the type of location at which the course is taught.", Description="Auxiliary", Definition="", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("c6383d54-d53c-4c55-a03d-deecca0e6472"), Code="Clinic or hospital is specified as the type of location at which the course is taught.", Description="ClinicHospital", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseInstructionSiteType Pick List
         /// </summary>
        public static List<RefCourseInstructionSiteType> RefCourseInstructionSiteTypePickList = new List<RefCourseInstructionSiteType> =
        {
            new RefCourseInstructionSiteType { Id=Guid.Parse("8dd28c74-a869-46dc-bdb9-52726b2350aa"), Code="On campus is specified as the type of location at which the course is taught.", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("8951df0b-36b5-4da8-9f69-061e016e1d74"), Code="Off campus (e.g., branch campus, etc.) is specified as the type of location at which the course is taught.", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("61ed6ccf-722c-4ec1-a161-a1ed1662dfd1"), Code="Extension center or site is specified as the type of location at which the course is taught.", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("e848c1eb-7bc8-4f4a-bbd7-2b82562c3f4b"), Code="Study abroad is specified as the type of location at which the course is taught.", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("70ef5dfb-4385-4955-a25d-60acaca28618"), Code="Correctional institution is specified as the type of location at which the course is taught.", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("43ba3f58-cd87-4ba2-bee7-bed79afb2480"), Code="Military Base is specified as the type of location at which the course is taught.", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("118af976-a343-42c3-ba0b-542ca7412d9c"), Code="Instructional telecommunications is specified as the type of location at which the course is taught.", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("0495827e-3946-41dc-8a4b-1892973d484f"), Code="Auxiliary is specified as the type of location at which the course is taught.", SortOrder=0 },
            new RefCourseInstructionSiteType { Id=Guid.Parse("c6383d54-d53c-4c55-a03d-deecca0e6472"), Code="Clinic or hospital is specified as the type of location at which the course is taught.", SortOrder=0 },
       };
   }
}
