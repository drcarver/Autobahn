//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInternetPerformanceInResidenceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInternetPerformanceInResidence Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInternetPerformanceInResidence"> List
         /// </summary>
        public static List<RefInternetPerformanceInResidence> RefInternetPerformanceInResidenceList = new List<RefInternetPerformanceInResidence> =
        {
            new RefInternetPerformanceInResidence { Id=Guid.Parse("80671cb8-9594-4158-87e0-86c87e4de2ad"), Code="The student is unable to complete learning activities due to poor internet performance in their primary place of residence.", Description="No", Definition="", SortOrder=0 },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("73dd9307-6b25-4a68-bed1-db228f6f4e07"), Code="The student regularly experiences interruptions in learning activities caused by poor internet performance in their primary place of residence.", Description="Sometimes", Definition="", SortOrder=0 },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("7650e70c-b738-4ac4-a286-60ca3c076c05"), Code="The student experiences very few or no interruptions in learning activities caused by poor internet performance in their primary place of residence.", Description="Yes", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefInternetPerformanceInResidence Pick List
         /// </summary>
        public static List<RefInternetPerformanceInResidence> RefInternetPerformanceInResidencePickList = new List<RefInternetPerformanceInResidence> =
        {
            new RefInternetPerformanceInResidence { Id=Guid.Parse("80671cb8-9594-4158-87e0-86c87e4de2ad"), Code="The student is unable to complete learning activities due to poor internet performance in their primary place of residence.", SortOrder=0 },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("73dd9307-6b25-4a68-bed1-db228f6f4e07"), Code="The student regularly experiences interruptions in learning activities caused by poor internet performance in their primary place of residence.", SortOrder=0 },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("7650e70c-b738-4ac4-a286-60ca3c076c05"), Code="The student experiences very few or no interruptions in learning activities caused by poor internet performance in their primary place of residence.", SortOrder=0 },
       };
   }
}
