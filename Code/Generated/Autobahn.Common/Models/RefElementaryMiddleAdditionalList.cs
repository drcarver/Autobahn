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
        public static List<RefElementaryMiddleAdditional> RefElementaryMiddleAdditionalList = new List<RefElementaryMiddleAdditional>
        {
            new RefElementaryMiddleAdditional { Id=Guid.Parse("4ea7bced-3eeb-4d45-b75f-b20a3fc7db26"), Code="MetAdditionalIndicator", Description="Met Additional Indicator", Definition="The school or district met the additional indicator for all students.", SortOrder=Convert.ToDecimal("1.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("a77bb5cc-248d-4388-af32-647c4f9f7d81"), Code="DidNotMeet", Description="Did Not Meet", Definition="The school or district did not meet the additional indicator for all students.", SortOrder=Convert.ToDecimal("2.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("436f47f7-c065-4ef5-b425-dcce74234836"), Code="TooFewStudents", Description="Too Few Students", Definition="The number of students in the school or district was less than the minimum group size outlined in a state's consolidated accountability workbook necessary required to reliably calculate the additional indicator status.", SortOrder=Convert.ToDecimal("3.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("9a0d87bb-41e3-4e73-baaa-046de4098e2d"), Code="NoStudents", Description="No Students", Definition="There were no students.", SortOrder=Convert.ToDecimal("4.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("fbd95694-6ea5-4fd3-add5-f31895cad99b"), Code="NA", Description="Not applicable", Definition="Elementary/Middle Additional Indicator status is not applicable.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefElementaryMiddleAdditional Pick List
         /// </summary>
        public static List<RefElementaryMiddleAdditional> RefElementaryMiddleAdditionalPickList = new List<RefElementaryMiddleAdditional>
        {
            new RefElementaryMiddleAdditional { Id=Guid.Parse("4ea7bced-3eeb-4d45-b75f-b20a3fc7db26"), Code="MetAdditionalIndicator", Description="Met Additional Indicator", SortOrder=Convert.ToDecimal("1.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("a77bb5cc-248d-4388-af32-647c4f9f7d81"), Code="DidNotMeet", Description="Did Not Meet", SortOrder=Convert.ToDecimal("2.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("436f47f7-c065-4ef5-b425-dcce74234836"), Code="TooFewStudents", Description="Too Few Students", SortOrder=Convert.ToDecimal("3.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("9a0d87bb-41e3-4e73-baaa-046de4098e2d"), Code="NoStudents", Description="No Students", SortOrder=Convert.ToDecimal("4.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("fbd95694-6ea5-4fd3-add5-f31895cad99b"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
