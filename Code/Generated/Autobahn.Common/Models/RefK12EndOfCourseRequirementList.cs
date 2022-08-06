//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefK12EndOfCourseRequirementList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefK12EndOfCourseRequirement Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefK12EndOfCourseRequirement"> List
         /// </summary>
        public static List<RefK12EndOfCourseRequirement> RefK12EndOfCourseRequirementList = new List<RefK12EndOfCourseRequirement>
        {
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("91c0fc9a-e111-4bf4-8a34-af63b38af3cd"), Code="LEAOnly", Description="LEA only", Definition="This course has an end of course examination required by the LEA only.", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("5e18df22-a42c-489a-a59f-9422caa46099"), Code="SEAOnly", Description="SEA only", Definition="This course has an end of course examination required by the SEA only.", SortOrder=Convert.ToDecimal("3.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("69b79d0b-21bc-4bfe-a96e-65a11efce79b"), Code="Both", Description="LEA and SEA", Definition="This course has an end of course examination required by the LEA and SEA.", SortOrder=Convert.ToDecimal("5.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("4f2895eb-2615-4b4b-8b9a-9ff8bfbb3f7c"), Code="Neither", Description="Neither LEA or SEA", Definition="This course has an end of course examination required by neither the LEA or SEA.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefK12EndOfCourseRequirement Pick List
         /// </summary>
        public static List<RefK12EndOfCourseRequirement> RefK12EndOfCourseRequirementPickList = new List<RefK12EndOfCourseRequirement>
        {
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("91c0fc9a-e111-4bf4-8a34-af63b38af3cd"), Code="LEAOnly", Description="LEA only", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("5e18df22-a42c-489a-a59f-9422caa46099"), Code="SEAOnly", Description="SEA only", SortOrder=Convert.ToDecimal("3.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("69b79d0b-21bc-4bfe-a96e-65a11efce79b"), Code="Both", Description="LEA and SEA", SortOrder=Convert.ToDecimal("5.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("4f2895eb-2615-4b4b-8b9a-9ff8bfbb3f7c"), Code="Neither", Description="Neither LEA or SEA", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
