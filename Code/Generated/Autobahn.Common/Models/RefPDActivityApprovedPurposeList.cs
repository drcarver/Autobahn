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
        public static List<RefPDActivityApprovedPurpose> RefPDActivityApprovedPurposeList = new List<RefPDActivityApprovedPurpose> =
        {
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("f440b682-91c1-475c-a677-657a01eaf07d"), Code="Quality Rating and Improvement System is the purposes for which the professional development activity was approved.", Description="QRIS", Definition="", SortOrder=0 },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("6a8d9354-a430-4f7d-8c12-3b0129058e57"), Code="Licensing is the purposes for which the professional development activity was approved.", Description="Licensing", Definition="", SortOrder=0 },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("8082084f-2086-42fe-8281-73a40d2a31f3"), Code="State standard is the purposes for which the professional development activity was approved.", Description="StateStandard", Definition="", SortOrder=0 },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("4108638b-a2af-482e-bb71-217b56222761"), Code="The purposes for which the professional development activity was approved is in a category not yet defined by CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPDActivityApprovedPurpose Pick List
         /// </summary>
        public static List<RefPDActivityApprovedPurpose> RefPDActivityApprovedPurposePickList = new List<RefPDActivityApprovedPurpose> =
        {
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("f440b682-91c1-475c-a677-657a01eaf07d"), Code="Quality Rating and Improvement System is the purposes for which the professional development activity was approved.", SortOrder=0 },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("6a8d9354-a430-4f7d-8c12-3b0129058e57"), Code="Licensing is the purposes for which the professional development activity was approved.", SortOrder=0 },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("8082084f-2086-42fe-8281-73a40d2a31f3"), Code="State standard is the purposes for which the professional development activity was approved.", SortOrder=0 },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("4108638b-a2af-482e-bb71-217b56222761"), Code="The purposes for which the professional development activity was approved is in a category not yet defined by CEDS.", SortOrder=0 },
       };
   }
}
