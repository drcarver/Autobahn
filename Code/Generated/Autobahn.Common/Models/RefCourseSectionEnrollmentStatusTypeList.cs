//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseSectionEnrollmentStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseSectionEnrollmentStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseSectionEnrollmentStatusType"> List
         /// </summary>
        public static List<RefCourseSectionEnrollmentStatusType> RefCourseSectionEnrollmentStatusTypeList = new List<RefCourseSectionEnrollmentStatusType> =
        {
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("15f5ab6b-dc05-4b68-91fe-53d6c67d22cd"), Code="Pre-registered is the status related to a student enrollment in an instance of a course.", Description="Pre-registered", Definition="", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("600e9719-e7ad-48bf-9c01-8fe62f224ecc"), Code="Registered is the status related to a student enrollment in an instance of a course.", Description="Registered", Definition="", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("e247166d-eb46-4ae8-8ade-a352cbfb1647"), Code="Enrolled is the status related to a student enrollment in an instance of a course.", Description="Enrolled", Definition="", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("135314ec-38e4-49c6-ac40-c89a3ab8bd0d"), Code="Wait Listed is the status related to a student enrollment in an instance of a course.", Description="WaitListed", Definition="", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("1d2b65f5-434b-4aa4-bd79-41e3d71e6eaa"), Code="Dropped is the status related to a student enrollment in an instance of a course.", Description="Dropped", Definition="", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("600260ac-020c-4b47-b2bc-e8417a0eacb5"), Code="Completed is the status related to a student enrollment in an instance of a course.", Description="Completed", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseSectionEnrollmentStatusType Pick List
         /// </summary>
        public static List<RefCourseSectionEnrollmentStatusType> RefCourseSectionEnrollmentStatusTypePickList = new List<RefCourseSectionEnrollmentStatusType> =
        {
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("15f5ab6b-dc05-4b68-91fe-53d6c67d22cd"), Code="Pre-registered is the status related to a student enrollment in an instance of a course.", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("600e9719-e7ad-48bf-9c01-8fe62f224ecc"), Code="Registered is the status related to a student enrollment in an instance of a course.", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("e247166d-eb46-4ae8-8ade-a352cbfb1647"), Code="Enrolled is the status related to a student enrollment in an instance of a course.", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("135314ec-38e4-49c6-ac40-c89a3ab8bd0d"), Code="Wait Listed is the status related to a student enrollment in an instance of a course.", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("1d2b65f5-434b-4aa4-bd79-41e3d71e6eaa"), Code="Dropped is the status related to a student enrollment in an instance of a course.", SortOrder=0 },
            new RefCourseSectionEnrollmentStatusType { Id=Guid.Parse("600260ac-020c-4b47-b2bc-e8417a0eacb5"), Code="Completed is the status related to a student enrollment in an instance of a course.", SortOrder=0 },
       };
   }
}
