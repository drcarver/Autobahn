//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCourseSectionEntryTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefCourseSectionEntryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseSectionEntryType"> List
         /// </summary>
        public static List<RefCourseSectionEntryType> RefCourseSectionEntryTypeList = new List<RefCourseSectionEntryType> =
        {
            new RefCourseSectionEntryType { Id=Guid.Parse("076b4aea-f4ae-4717-99b6-1d016a73df73"), Code="New Class Section enrollment.", Description="NewEnrollment", Definition="", SortOrder=0 },
            new RefCourseSectionEntryType { Id=Guid.Parse("1e836425-a951-4b6b-9081-e89ee4815d16"), Code="Student transferred from another Class Section of the same course in the same educational institution.", Description="Transfer", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseSectionEntryType Pick List
         /// </summary>
        public static List<RefCourseSectionEntryType> RefCourseSectionEntryTypePickList = new List<RefCourseSectionEntryType> =
        {
            new RefCourseSectionEntryType { Id=Guid.Parse("076b4aea-f4ae-4717-99b6-1d016a73df73"), Code="New Class Section enrollment.", SortOrder=0 },
            new RefCourseSectionEntryType { Id=Guid.Parse("1e836425-a951-4b6b-9081-e89ee4815d16"), Code="Student transferred from another Class Section of the same course in the same educational institution.", SortOrder=0 },
       };
   }
}
