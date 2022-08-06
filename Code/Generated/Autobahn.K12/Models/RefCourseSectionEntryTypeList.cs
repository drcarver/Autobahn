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
        public static List<RefCourseSectionEntryType> RefCourseSectionEntryTypeList = new List<RefCourseSectionEntryType>
        {
            new RefCourseSectionEntryType { Id=Guid.Parse("c9b5a773-11bc-4cc9-a59b-4d2d5080d107"), Code="NewEnrollment", Description="New Enrollment", Definition="New Class Section enrollment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionEntryType { Id=Guid.Parse("9a761a64-5b76-46b6-b86b-fb49aafbc76c"), Code="Transfer", Description="Transfer", Definition="Student transferred from another Class Section of the same course in the same educational institution.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefCourseSectionEntryType Pick List
         /// </summary>
        public static List<RefCourseSectionEntryType> RefCourseSectionEntryTypePickList = new List<RefCourseSectionEntryType>
        {
            new RefCourseSectionEntryType { Id=Guid.Parse("c9b5a773-11bc-4cc9-a59b-4d2d5080d107"), Code="NewEnrollment", Description="New Enrollment", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionEntryType { Id=Guid.Parse("9a761a64-5b76-46b6-b86b-fb49aafbc76c"), Code="Transfer", Description="Transfer", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
