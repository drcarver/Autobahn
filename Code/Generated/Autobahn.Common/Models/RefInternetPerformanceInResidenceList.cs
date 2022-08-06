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
        public static List<RefInternetPerformanceInResidence> RefInternetPerformanceInResidenceList = new List<RefInternetPerformanceInResidence>
        {
            new RefInternetPerformanceInResidence { Id=Guid.Parse("9b5022ac-2adb-40f9-b002-0dc07ee08c95"), Code="No", Description="No", Definition="The student is unable to complete learning activities due to poor internet performance in their primary place of residence.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("f1613b1a-685a-47f6-9872-c948aa309eca"), Code="Sometimes", Description="Sometimes", Definition="The student regularly experiences interruptions in learning activities caused by poor internet performance in their primary place of residence.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("5bc6fb08-19ad-48a8-87f9-2f12d82da350"), Code="Yes", Description="Yes", Definition="The student experiences very few or no interruptions in learning activities caused by poor internet performance in their primary place of residence.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefInternetPerformanceInResidence Pick List
         /// </summary>
        public static List<RefInternetPerformanceInResidence> RefInternetPerformanceInResidencePickList = new List<RefInternetPerformanceInResidence>
        {
            new RefInternetPerformanceInResidence { Id=Guid.Parse("9b5022ac-2adb-40f9-b002-0dc07ee08c95"), Code="No", Description="No", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("f1613b1a-685a-47f6-9872-c948aa309eca"), Code="Sometimes", Description="Sometimes", SortOrder=Convert.ToDecimal("2.00") },
            new RefInternetPerformanceInResidence { Id=Guid.Parse("5bc6fb08-19ad-48a8-87f9-2f12d82da350"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
