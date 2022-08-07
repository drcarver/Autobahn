//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRecordStatusTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRecordStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRecordStatusTypeModel"> List
         /// </summary>
        public static List<RefRecordStatusTypeModel> RefRecordStatusTypeList = new List<RefRecordStatusTypeModel>
        {
            new RefRecordStatusType { Id=Guid.Parse("5124f3f9-0f8a-47cb-a2f3-c5fcf347ba47"), Code="Certified", Description="Certified", Definition="A person or organization with authority over this record or this process indicated the record was complete and accurate to the best of their knowledge.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRecordStatusType { Id=Guid.Parse("b8aba0d0-0978-45a2-ba73-cb68cfb8cbf5"), Code="Decertified", Description="Decertified", Definition="A person or organization with authority over this record or this process indicated they wish to reverse the decision that was previously indicated through the status of Certified.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRecordStatusType { Id=Guid.Parse("fc051510-a02a-45f1-9cca-a2609f437c0f"), Code="Deleted", Description="Deleted", Definition="This record is no longer valid.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRecordStatusType { Id=Guid.Parse("030fd82b-528c-4f94-a1bc-8e1cb7c758be"), Code="InProcess", Description="In Process", Definition="The data in this record are potentially transactional in nature.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRecordStatusType { Id=Guid.Parse("23f4ead3-6be8-4c7a-9ab2-44779a944831"), Code="Published", Description="Published", Definition="The data in this record is in use or was used for federal, state, or local reporting or to fulfill research or data request purposes.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRecordStatusType { Id=Guid.Parse("c1b79ace-dff8-41a7-8441-63a07e29b9fb"), Code="Retired", Description="Retired", Definition="The data in this record was once valid for use and is no longer valid for use per the requirements defined by the organization responsible for the record.", SortOrder=Convert.ToDecimal("6.00") },
            new RefRecordStatusType { Id=Guid.Parse("0bab542d-25e4-45d9-9e5c-1b8e3302b75e"), Code="Submitted", Description="Submitted", Definition="The data in this record are not transactional in nature but are complete and do not require any formal certification process.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefRecordStatusType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefRecordStatusTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefRecordStatusType { Id=Guid.Parse("5124f3f9-0f8a-47cb-a2f3-c5fcf347ba47"), Description="Certified", SortOrder=Convert.ToDecimal("1.00") },
            new RefRecordStatusType { Id=Guid.Parse("b8aba0d0-0978-45a2-ba73-cb68cfb8cbf5"), Description="Decertified", SortOrder=Convert.ToDecimal("2.00") },
            new RefRecordStatusType { Id=Guid.Parse("fc051510-a02a-45f1-9cca-a2609f437c0f"), Description="Deleted", SortOrder=Convert.ToDecimal("3.00") },
            new RefRecordStatusType { Id=Guid.Parse("030fd82b-528c-4f94-a1bc-8e1cb7c758be"), Description="In Process", SortOrder=Convert.ToDecimal("4.00") },
            new RefRecordStatusType { Id=Guid.Parse("23f4ead3-6be8-4c7a-9ab2-44779a944831"), Description="Published", SortOrder=Convert.ToDecimal("5.00") },
            new RefRecordStatusType { Id=Guid.Parse("c1b79ace-dff8-41a7-8441-63a07e29b9fb"), Description="Retired", SortOrder=Convert.ToDecimal("6.00") },
            new RefRecordStatusType { Id=Guid.Parse("0bab542d-25e4-45d9-9e5c-1b8e3302b75e"), Description="Submitted", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
