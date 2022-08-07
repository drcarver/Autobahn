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
        /// The complete <see cref="RefCourseSectionEntryTypeModel"> List
         /// </summary>
        public static List<RefCourseSectionEntryTypeModel> RefCourseSectionEntryTypeList = new List<RefCourseSectionEntryTypeModel>
        {
            new RefCourseSectionEntryType { Id=Guid.Parse("5c443311-242c-4cc2-a98c-03d6a6e14f23"), Code="NewEnrollment", Description="New Enrollment", Definition="New Class Section enrollment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionEntryType { Id=Guid.Parse("77b1733c-2ce7-4fb4-9751-5ab3d840fd7f"), Code="Transfer", Description="Transfer", Definition="Student transferred from another Class Section of the same course in the same educational institution.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefCourseSectionEntryType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseSectionEntryTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseSectionEntryType { Id=Guid.Parse("5c443311-242c-4cc2-a98c-03d6a6e14f23"), Description="New Enrollment", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionEntryType { Id=Guid.Parse("77b1733c-2ce7-4fb4-9751-5ab3d840fd7f"), Description="Transfer", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
