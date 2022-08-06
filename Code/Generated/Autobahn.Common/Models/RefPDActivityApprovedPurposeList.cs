//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityApprovedPurposeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityApprovedPurpose Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityApprovedPurpose"> List
         /// </summary>
        public static List<RefPDActivityApprovedPurpose> RefPDActivityApprovedPurposeList = new List<RefPDActivityApprovedPurpose>
        {
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("cdbb1ed2-e6ba-4eee-8a49-29eb3fe9ba7e"), Code="QRIS", Description="Quality Rating and Improvement System", Definition="Quality Rating and Improvement System is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("3ebe16bd-0d72-471c-8543-c326eb37b3bf"), Code="Licensing", Description="Licensing", Definition="Licensing is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("a697bbc3-8c88-44ab-b14f-a2404f7277ed"), Code="StateStandard", Description="State standard", Definition="State standard is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("8f36b0d0-725d-4af3-9b3d-563b9ee0c05c"), Code="Other", Description="Other", Definition="The purposes for which the professional development activity was approved is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefPDActivityApprovedPurpose Pick List
         /// </summary>
        public static List<RefPDActivityApprovedPurpose> RefPDActivityApprovedPurposePickList = new List<RefPDActivityApprovedPurpose>
        {
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("cdbb1ed2-e6ba-4eee-8a49-29eb3fe9ba7e"), Code="QRIS", Description="Quality Rating and Improvement System", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("3ebe16bd-0d72-471c-8543-c326eb37b3bf"), Code="Licensing", Description="Licensing", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("a697bbc3-8c88-44ab-b14f-a2404f7277ed"), Code="StateStandard", Description="State standard", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("8f36b0d0-725d-4af3-9b3d-563b9ee0c05c"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
