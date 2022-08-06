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
        /// The complete <see cref="RefCourseSectionExitType"> List
         /// </summary>
        public static List<RefCourseSectionExitType> RefCourseSectionExitTypeList = new List<RefCourseSectionExitType>
        {
            new RefCourseSectionExitType { Id=Guid.Parse("8ad3d45a-5019-46c7-8829-4d08ae100c15"), Code="Transfer", Description="Student transferred to another Class Section of the same course in the same educational institution.", Definition="The student exited the course section and transferred to another course section of the same course in the same educational institution.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("2fcfd82d-f613-44e1-8421-c9b52479c588"), Code="CompletedForCredit", Description="Class Section completed, student received credit for the course.", Definition="The course section completed and the student received credit for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("060788dd-a586-4a9a-a6aa-537525cf739f"), Code="CompletedNoCredit", Description="Class Section completed, student did not receive credit for the course.", Definition="The course section completed and the student did not receive credit for the course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("0ffb740c-a079-473e-8766-a8a338f42ca1"), Code="Incomplete", Description="Class Section completed, student did not complete the work required to complete the course.", Definition="The course section ended and the student did not complete the work required to complete the course.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefCourseSectionExitType Pick List
         /// </summary>
        public static List<RefCourseSectionExitType> RefCourseSectionExitTypePickList = new List<RefCourseSectionExitType>
        {
            new RefCourseSectionExitType { Id=Guid.Parse("8ad3d45a-5019-46c7-8829-4d08ae100c15"), Code="Transfer", Description="Student transferred to another Class Section of the same course in the same educational institution.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("2fcfd82d-f613-44e1-8421-c9b52479c588"), Code="CompletedForCredit", Description="Class Section completed, student received credit for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("060788dd-a586-4a9a-a6aa-537525cf739f"), Code="CompletedNoCredit", Description="Class Section completed, student did not receive credit for the course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseSectionExitType { Id=Guid.Parse("0ffb740c-a079-473e-8766-a8a338f42ca1"), Code="Incomplete", Description="Class Section completed, student did not complete the work required to complete the course.", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
