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
        public static List<RefRecordStatusType> RefRecordStatusTypeList = new List<RefRecordStatusType> =
        {
            new RefRecordStatusType { Id=Guid.Parse("7e40f4e7-254f-4361-a9c2-e84273bfecd3"), Code="A person or organization with authority over this record or this process indicated the record was complete and accurate to the best of their knowledge.", Description="Certified", Definition="", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("5cdb14ba-6b9d-4517-a463-c7ae70e8a981"), Code="A person or organization with authority over this record or this process indicated they wish to reverse the decision that was previously indicated through the status of Certified.", Description="Decertified", Definition="", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("82f34496-ba8c-4f68-b77c-0113509ed02a"), Code="This record is no longer valid.", Description="Deleted", Definition="", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("d4b1f81b-0a7d-45be-b18d-8af811e002f9"), Code="The data in this record are potentially transactional in nature.", Description="InProcess", Definition="", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("51b86c06-e429-474d-a65d-04f33353c0c9"), Code="The data in this record is in use or was used for federal, state, or local reporting or to fulfill research or data request purposes.", Description="Published", Definition="", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("beaf1b93-90c4-4cbd-864f-afff0662fc2a"), Code="The data in this record was once valid for use and is no longer valid for use per the requirements defined by the organization responsible for the record.", Description="Retired", Definition="", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("65e0e155-384f-4878-9f8b-499e045052c1"), Code="The data in this record are not transactional in nature but are complete and do not require any formal certification process.", Description="Submitted", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefRecordStatusType Pick List
         /// </summary>
        public static List<RefRecordStatusType> RefRecordStatusTypePickList = new List<RefRecordStatusType> =
        {
            new RefRecordStatusType { Id=Guid.Parse("7e40f4e7-254f-4361-a9c2-e84273bfecd3"), Code="A person or organization with authority over this record or this process indicated the record was complete and accurate to the best of their knowledge.", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("5cdb14ba-6b9d-4517-a463-c7ae70e8a981"), Code="A person or organization with authority over this record or this process indicated they wish to reverse the decision that was previously indicated through the status of Certified.", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("82f34496-ba8c-4f68-b77c-0113509ed02a"), Code="This record is no longer valid.", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("d4b1f81b-0a7d-45be-b18d-8af811e002f9"), Code="The data in this record are potentially transactional in nature.", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("51b86c06-e429-474d-a65d-04f33353c0c9"), Code="The data in this record is in use or was used for federal, state, or local reporting or to fulfill research or data request purposes.", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("beaf1b93-90c4-4cbd-864f-afff0662fc2a"), Code="The data in this record was once valid for use and is no longer valid for use per the requirements defined by the organization responsible for the record.", SortOrder=0 },
            new RefRecordStatusType { Id=Guid.Parse("65e0e155-384f-4878-9f8b-499e045052c1"), Code="The data in this record are not transactional in nature but are complete and do not require any formal certification process.", SortOrder=0 },
       };
   }
}
