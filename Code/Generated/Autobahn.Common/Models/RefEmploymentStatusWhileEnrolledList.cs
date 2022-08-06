//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmploymentStatusWhileEnrolledList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmploymentStatusWhileEnrolled Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmploymentStatusWhileEnrolled"> List
         /// </summary>
        public static List<RefEmploymentStatusWhileEnrolled> RefEmploymentStatusWhileEnrolledList = new List<RefEmploymentStatusWhileEnrolled>
        {
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("75477bed-b74f-48ed-acd8-7da9d316856f"), Code="01", Description="Full-time", Definition="Full-time is the individual's employment status while enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("3bacb0a7-e5f3-4ac7-868d-512d3b873ca9"), Code="02", Description="Less than full-time but at least half-time", Definition="Less than full-time but at least half-time is the individual's employment status while enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("66d5f6a8-ccc6-40e3-90ab-17e5099ce2f6"), Code="03", Description="Less than half-time", Definition="Less than half-time is the individual's employment status while enrolled.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefEmploymentStatusWhileEnrolled Pick List
         /// </summary>
        public static List<RefEmploymentStatusWhileEnrolled> RefEmploymentStatusWhileEnrolledPickList = new List<RefEmploymentStatusWhileEnrolled>
        {
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("75477bed-b74f-48ed-acd8-7da9d316856f"), Code="01", Description="Full-time", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("3bacb0a7-e5f3-4ac7-868d-512d3b873ca9"), Code="02", Description="Less than full-time but at least half-time", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("66d5f6a8-ccc6-40e3-90ab-17e5099ce2f6"), Code="03", Description="Less than half-time", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
