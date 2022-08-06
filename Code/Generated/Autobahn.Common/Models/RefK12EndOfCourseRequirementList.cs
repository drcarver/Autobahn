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
        public static List<RefK12EndOfCourseRequirement> RefK12EndOfCourseRequirementList = new List<RefK12EndOfCourseRequirement> =
        {
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("8e156fb6-5325-40c1-ba00-4533bb562f36"), Code="This course has an end of course examination required by the LEA only.", Description="LEAOnly", Definition="", SortOrder=0 },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("de4ce0c6-d2a7-40de-ac34-b257b37495d2"), Code="This course has an end of course examination required by the SEA only.", Description="SEAOnly", Definition="", SortOrder=0 },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("9e61856a-37cc-4590-b2ee-733971460ff2"), Code="This course has an end of course examination required by the LEA and SEA.", Description="Both", Definition="", SortOrder=0 },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("b15beeb8-21a8-4bc0-b8a0-1f1e629575f1"), Code="This course has an end of course examination required by neither the LEA or SEA.", Description="Neither", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefK12EndOfCourseRequirement Pick List
         /// </summary>
        public static List<RefK12EndOfCourseRequirement> RefK12EndOfCourseRequirementPickList = new List<RefK12EndOfCourseRequirement> =
        {
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("8e156fb6-5325-40c1-ba00-4533bb562f36"), Code="This course has an end of course examination required by the LEA only.", SortOrder=0 },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("de4ce0c6-d2a7-40de-ac34-b257b37495d2"), Code="This course has an end of course examination required by the SEA only.", SortOrder=0 },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("9e61856a-37cc-4590-b2ee-733971460ff2"), Code="This course has an end of course examination required by the LEA and SEA.", SortOrder=0 },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("b15beeb8-21a8-4bc0-b8a0-1f1e629575f1"), Code="This course has an end of course examination required by neither the LEA or SEA.", SortOrder=0 },
       };
   }
}
