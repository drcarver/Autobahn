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
        public static List<RefInstructionalStaffContractLength> RefInstructionalStaffContractLengthList = new List<RefInstructionalStaffContractLength> =
        {
            new RefInstructionalStaffContractLength { Id=Guid.Parse("dbf229fe-76fd-42a6-a450-37732e95143e"), Code="The contracted teaching period for the faculty member is less than 9-Months.", Description="LessThan9-Month", Definition="", SortOrder=0 },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("0db54e91-f515-4d94-8a14-318d6558a1aa"), Code="The contracted teaching period for the faculty member 9-Months.", Description="9-Month", Definition="", SortOrder=0 },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("c7ee21e7-a67d-43a0-a930-2299489a28bb"), Code="The contracted teaching period for the faculty member 10-Months.", Description="10-Month", Definition="", SortOrder=0 },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("e3fae842-dee4-4ca9-bacd-f9d97e9cc1ad"), Code="The contracted teaching period for the faculty member 11-Months.", Description="11-Month", Definition="", SortOrder=0 },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("d964d4c7-18a5-400a-8a5f-5991f71d2255"), Code="The contracted teaching period for the faculty member 12-Months.", Description="12-Month", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefInstructionalStaffContractLength Pick List
         /// </summary>
        public static List<RefInstructionalStaffContractLength> RefInstructionalStaffContractLengthPickList = new List<RefInstructionalStaffContractLength> =
        {
            new RefInstructionalStaffContractLength { Id=Guid.Parse("dbf229fe-76fd-42a6-a450-37732e95143e"), Code="The contracted teaching period for the faculty member is less than 9-Months.", SortOrder=0 },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("0db54e91-f515-4d94-8a14-318d6558a1aa"), Code="The contracted teaching period for the faculty member 9-Months.", SortOrder=0 },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("c7ee21e7-a67d-43a0-a930-2299489a28bb"), Code="The contracted teaching period for the faculty member 10-Months.", SortOrder=0 },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("e3fae842-dee4-4ca9-bacd-f9d97e9cc1ad"), Code="The contracted teaching period for the faculty member 11-Months.", SortOrder=0 },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("d964d4c7-18a5-400a-8a5f-5991f71d2255"), Code="The contracted teaching period for the faculty member 12-Months.", SortOrder=0 },
       };
   }
}
