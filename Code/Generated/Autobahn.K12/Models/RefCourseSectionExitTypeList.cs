//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCourseSectionExitTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefCourseSectionExitType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseSectionExitTypeModel"> List
         /// </summary>
        public static List<RefCourseSectionExitTypeModel> RefCourseSectionExitTypeList = new List<RefCourseSectionExitTypeModel>
        {
            new RefCourseSectionExitType { Id=Guid.Parse("391a0a3f-67cc-49ab-bbff-d603dcad4784"), Code="Transfer", Description="Student transferred to another Class Section of the same course in the same educational institution.", Definition="The student exited the course section and transferred to another course section of the same course in the same educational institution.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("d17fb316-c02f-4d84-bcc4-e90d8cab2bf3"), Code="CompletedForCredit", Description="Class Section completed, student received credit for the course.", Definition="The course section completed and the student received credit for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("a993ff47-e727-454f-93ef-514cd9b4d8cf"), Code="CompletedNoCredit", Description="Class Section completed, student did not receive credit for the course.", Definition="The course section completed and the student did not receive credit for the course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("7dea59d2-879f-47ac-9a9f-25455b249e15"), Code="Incomplete", Description="Class Section completed, student did not complete the work required to complete the course.", Definition="The course section ended and the student did not complete the work required to complete the course.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefCourseSectionExitType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseSectionExitTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseSectionExitType { Id=Guid.Parse("391a0a3f-67cc-49ab-bbff-d603dcad4784"), Description="Student transferred to another Class Section of the same course in the same educational institution.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("d17fb316-c02f-4d84-bcc4-e90d8cab2bf3"), Description="Class Section completed, student received credit for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("a993ff47-e727-454f-93ef-514cd9b4d8cf"), Description="Class Section completed, student did not receive credit for the course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("7dea59d2-879f-47ac-9a9f-25455b249e15"), Description="Class Section completed, student did not complete the work required to complete the course.", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
