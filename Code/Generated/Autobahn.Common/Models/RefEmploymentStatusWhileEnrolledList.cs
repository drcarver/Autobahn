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
        public static List<RefEmploymentStatusWhileEnrolled> RefEmploymentStatusWhileEnrolledList = new List<RefEmploymentStatusWhileEnrolled> =
        {
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("eddfc828-a3e7-4206-b3ac-3bb4e70a444d"), Code="Full-time is the individual's employment status while enrolled.", Description="01", Definition="", SortOrder=0 },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("81d38c4d-fb90-47fa-b19e-fa7893ea5e45"), Code="Less than full-time but at least half-time is the individual's employment status while enrolled.", Description="02", Definition="", SortOrder=0 },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("4486cf2a-1b6b-4eb4-9abb-2e295eea8930"), Code="Less than half-time is the individual's employment status while enrolled.", Description="03", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEmploymentStatusWhileEnrolled Pick List
         /// </summary>
        public static List<RefEmploymentStatusWhileEnrolled> RefEmploymentStatusWhileEnrolledPickList = new List<RefEmploymentStatusWhileEnrolled> =
        {
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("eddfc828-a3e7-4206-b3ac-3bb4e70a444d"), Code="Full-time is the individual's employment status while enrolled.", SortOrder=0 },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("81d38c4d-fb90-47fa-b19e-fa7893ea5e45"), Code="Less than full-time but at least half-time is the individual's employment status while enrolled.", SortOrder=0 },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("4486cf2a-1b6b-4eb4-9abb-2e295eea8930"), Code="Less than half-time is the individual's employment status while enrolled.", SortOrder=0 },
       };
   }
}
