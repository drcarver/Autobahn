//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefElementaryMiddleAdditionalList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefElementaryMiddleAdditional Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefElementaryMiddleAdditional"> List
         /// </summary>
        public static List<RefElementaryMiddleAdditional> RefElementaryMiddleAdditionalList = new List<RefElementaryMiddleAdditional> =
        {
            new RefElementaryMiddleAdditional { Id=Guid.Parse("88e844b1-3e4e-4c9c-be36-7f6ae89312c7"), Code="The school or district met the additional indicator for all students.", Description="MetAdditionalIndicator", Definition="", SortOrder=0 },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("d82d84d0-afdd-4772-a6ed-d45e386a87f4"), Code="The school or district did not meet the additional indicator for all students.", Description="DidNotMeet", Definition="", SortOrder=0 },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("58449e12-ee12-46cc-ba9b-8f10562a5cd1"), Code="The number of students in the school or district was less than the minimum group size outlined in a state's consolidated accountability workbook necessary required to reliably calculate the additional indicator status.", Description="TooFewStudents", Definition="", SortOrder=0 },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("25a7f5ce-baac-49af-9ca7-9e374acc4a1b"), Code="There were no students.", Description="NoStudents", Definition="", SortOrder=0 },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("e27969f3-f666-46b1-98a5-c6ae4cab87c8"), Code="Elementary/Middle Additional Indicator status is not applicable.", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefElementaryMiddleAdditional Pick List
         /// </summary>
        public static List<RefElementaryMiddleAdditional> RefElementaryMiddleAdditionalPickList = new List<RefElementaryMiddleAdditional> =
        {
            new RefElementaryMiddleAdditional { Id=Guid.Parse("88e844b1-3e4e-4c9c-be36-7f6ae89312c7"), Code="The school or district met the additional indicator for all students.", SortOrder=0 },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("d82d84d0-afdd-4772-a6ed-d45e386a87f4"), Code="The school or district did not meet the additional indicator for all students.", SortOrder=0 },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("58449e12-ee12-46cc-ba9b-8f10562a5cd1"), Code="The number of students in the school or district was less than the minimum group size outlined in a state's consolidated accountability workbook necessary required to reliably calculate the additional indicator status.", SortOrder=0 },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("25a7f5ce-baac-49af-9ca7-9e374acc4a1b"), Code="There were no students.", SortOrder=0 },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("e27969f3-f666-46b1-98a5-c6ae4cab87c8"), Code="Elementary/Middle Additional Indicator status is not applicable.", SortOrder=0 },
       };
   }
}
