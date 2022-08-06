//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRecordStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRecordStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRecordStatusType"> List
         /// </summary>
        public static List<RefRecordStatusType> RefRecordStatusTypeList = new List<RefRecordStatusType>
        {
            new RefRecordStatusType { Id=Guid.Parse("446d13ec-c3fb-47dd-999b-6996efaac94d"), Code="Certified", Description="Certified", Definition="A person or organization with authority over this record or this process indicated the record was complete and accurate to the best of their knowledge.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRecordStatusType { Id=Guid.Parse("2e02a949-c895-4939-bd5c-c3f97f39b500"), Code="Decertified", Description="Decertified", Definition="A person or organization with authority over this record or this process indicated they wish to reverse the decision that was previously indicated through the status of Certified.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRecordStatusType { Id=Guid.Parse("54d49d39-9615-45e1-ae17-609b3c1ade31"), Code="Deleted", Description="Deleted", Definition="This record is no longer valid.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRecordStatusType { Id=Guid.Parse("298e8cbe-684b-48de-9797-fb1f6dece5d6"), Code="InProcess", Description="In Process", Definition="The data in this record are potentially transactional in nature.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRecordStatusType { Id=Guid.Parse("1c2d0e8b-c75b-4d20-ab16-755e4b36bab7"), Code="Published", Description="Published", Definition="The data in this record is in use or was used for federal, state, or local reporting or to fulfill research or data request purposes.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRecordStatusType { Id=Guid.Parse("908163bd-3cf7-46d8-8b1f-fc2ada41e713"), Code="Retired", Description="Retired", Definition="The data in this record was once valid for use and is no longer valid for use per the requirements defined by the organization responsible for the record.", SortOrder=Convert.ToDecimal("6.00") },
            new RefRecordStatusType { Id=Guid.Parse("a26b7c94-32ef-4933-8907-07a5a1896fd8"), Code="Submitted", Description="Submitted", Definition="The data in this record are not transactional in nature but are complete and do not require any formal certification process.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefRecordStatusType Pick List
         /// </summary>
        public static List<RefRecordStatusType> RefRecordStatusTypePickList = new List<RefRecordStatusType>
        {
            new RefRecordStatusType { Id=Guid.Parse("446d13ec-c3fb-47dd-999b-6996efaac94d"), Code="Certified", Description="Certified", SortOrder=Convert.ToDecimal("1.00") },
            new RefRecordStatusType { Id=Guid.Parse("2e02a949-c895-4939-bd5c-c3f97f39b500"), Code="Decertified", Description="Decertified", SortOrder=Convert.ToDecimal("2.00") },
            new RefRecordStatusType { Id=Guid.Parse("54d49d39-9615-45e1-ae17-609b3c1ade31"), Code="Deleted", Description="Deleted", SortOrder=Convert.ToDecimal("3.00") },
            new RefRecordStatusType { Id=Guid.Parse("298e8cbe-684b-48de-9797-fb1f6dece5d6"), Code="InProcess", Description="In Process", SortOrder=Convert.ToDecimal("4.00") },
            new RefRecordStatusType { Id=Guid.Parse("1c2d0e8b-c75b-4d20-ab16-755e4b36bab7"), Code="Published", Description="Published", SortOrder=Convert.ToDecimal("5.00") },
            new RefRecordStatusType { Id=Guid.Parse("908163bd-3cf7-46d8-8b1f-fc2ada41e713"), Code="Retired", Description="Retired", SortOrder=Convert.ToDecimal("6.00") },
            new RefRecordStatusType { Id=Guid.Parse("a26b7c94-32ef-4933-8907-07a5a1896fd8"), Code="Submitted", Description="Submitted", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
