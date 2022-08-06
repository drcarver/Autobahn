//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefInstructionalStaffContractLengthList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefInstructionalStaffContractLength Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInstructionalStaffContractLength"> List
         /// </summary>
        public static List<RefInstructionalStaffContractLength> RefInstructionalStaffContractLengthList = new List<RefInstructionalStaffContractLength>
        {
            new RefInstructionalStaffContractLength { Id=Guid.Parse("963bed18-e3e6-4e0a-8e7f-2043de235e57"), Code="LessThan9-Month", Description="Less than 9-Month", Definition="The contracted teaching period for the faculty member is less than 9-Months.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("6abf7c36-a87a-49f6-af6f-1570a9fc7a3f"), Code="9-Month", Description="9-Month", Definition="The contracted teaching period for the faculty member 9-Months.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("bd026c99-a06f-4dbd-9eb1-7a02c47967ea"), Code="10-Month", Description="10-Month", Definition="The contracted teaching period for the faculty member 10-Months.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("78b6c2cd-ac90-42b3-9b00-03cdb3bec215"), Code="11-Month", Description="11-Month", Definition="The contracted teaching period for the faculty member 11-Months.", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("71b81eb1-b9de-4756-943f-8c95189ccd4d"), Code="12-Month", Description="12-Month", Definition="The contracted teaching period for the faculty member 12-Months.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefInstructionalStaffContractLength Pick List
         /// </summary>
        public static List<RefInstructionalStaffContractLength> RefInstructionalStaffContractLengthPickList = new List<RefInstructionalStaffContractLength>
        {
            new RefInstructionalStaffContractLength { Id=Guid.Parse("963bed18-e3e6-4e0a-8e7f-2043de235e57"), Code="LessThan9-Month", Description="Less than 9-Month", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("6abf7c36-a87a-49f6-af6f-1570a9fc7a3f"), Code="9-Month", Description="9-Month", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("bd026c99-a06f-4dbd-9eb1-7a02c47967ea"), Code="10-Month", Description="10-Month", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("78b6c2cd-ac90-42b3-9b00-03cdb3bec215"), Code="11-Month", Description="11-Month", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("71b81eb1-b9de-4756-943f-8c95189ccd4d"), Code="12-Month", Description="12-Month", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
