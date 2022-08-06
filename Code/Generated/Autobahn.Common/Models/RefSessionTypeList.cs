//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSessionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSessionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSessionType"> List
         /// </summary>
        public static List<RefSessionType> RefSessionTypeList = new List<RefSessionType> =
        {
            new RefSessionType { Id=Guid.Parse("cb27463d-1c28-44f6-a44a-31798b635fd7"), Code="A regular school term consisting of no major subdivision of time segments. It usually begins in the late summer or early fall and ends in late spring or early summer (e.g., elementary school).", Description="FullSchoolYear", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("e16dd7f3-e6d3-4375-97fb-55448161b92d"), Code="A short session which occurs between longer sessions.", Description="Intersession", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("4b6b7723-dcda-48b6-9326-1e9cbd075c1a"), Code="A session that is longer than a semester but shorter than a full year.", Description="LongSession", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("d0614ae6-8405-4ea7-84f5-05ce51ccb632"), Code="A school term which is shorter than a regular session.", Description="MiniTerm", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("163b1baa-3503-4669-ace2-b90484677aba"), Code="One of four equal segments into which a school year is divided.", Description="Quarter", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("07851e2e-c069-4fad-90ac-8e915fd0c6bd"), Code="One of five equal segments into which a school year is divided.", Description="Quinmester", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("a35494fa-311b-4696-8ba3-c523ad758a43"), Code="One of two equal segments into which a school year is divided.", Description="Semester", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("007215e0-f6e2-4f24-8f65-1a55e468198d"), Code="A school term which takes place in the summer between two regular school terms.", Description="SummerTerm", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("99df94e0-f9b8-4aa9-8552-ba6832ae54db"), Code="One of three equal segments into which a school year is divided.", Description="Trimester", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("df1035d9-c96b-4cb7-86ef-3e278a215cf5"), Code="An educational program that operates on a full twelve month cycle.", Description="TwelveMonth", Definition="", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("d6c46082-c5dc-4a03-970f-bae99d3a8e5b"), Code="The session type is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefSessionType Pick List
         /// </summary>
        public static List<RefSessionType> RefSessionTypePickList = new List<RefSessionType> =
        {
            new RefSessionType { Id=Guid.Parse("cb27463d-1c28-44f6-a44a-31798b635fd7"), Code="A regular school term consisting of no major subdivision of time segments. It usually begins in the late summer or early fall and ends in late spring or early summer (e.g., elementary school).", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("e16dd7f3-e6d3-4375-97fb-55448161b92d"), Code="A short session which occurs between longer sessions.", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("4b6b7723-dcda-48b6-9326-1e9cbd075c1a"), Code="A session that is longer than a semester but shorter than a full year.", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("d0614ae6-8405-4ea7-84f5-05ce51ccb632"), Code="A school term which is shorter than a regular session.", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("163b1baa-3503-4669-ace2-b90484677aba"), Code="One of four equal segments into which a school year is divided.", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("07851e2e-c069-4fad-90ac-8e915fd0c6bd"), Code="One of five equal segments into which a school year is divided.", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("a35494fa-311b-4696-8ba3-c523ad758a43"), Code="One of two equal segments into which a school year is divided.", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("007215e0-f6e2-4f24-8f65-1a55e468198d"), Code="A school term which takes place in the summer between two regular school terms.", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("99df94e0-f9b8-4aa9-8552-ba6832ae54db"), Code="One of three equal segments into which a school year is divided.", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("df1035d9-c96b-4cb7-86ef-3e278a215cf5"), Code="An educational program that operates on a full twelve month cycle.", SortOrder=0 },
            new RefSessionType { Id=Guid.Parse("d6c46082-c5dc-4a03-970f-bae99d3a8e5b"), Code="The session type is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
