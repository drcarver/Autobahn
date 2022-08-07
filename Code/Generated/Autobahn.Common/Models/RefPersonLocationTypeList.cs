//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonLocationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPersonLocationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPersonLocationTypeModel"> List
         /// </summary>
        public static List<RefPersonLocationTypeModel> RefPersonLocationTypeList = new List<RefPersonLocationTypeModel>
        {
            new RefPersonLocationType { Id=Guid.Parse("b6037373-be0c-4132-af0b-b191d7bee6c5"), Code="Mailing", Description="Mailing", Definition="Mailing is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("40afc1b4-6bd0-4b47-b6d1-77f857034fa2"), Code="Physical", Description="Physical", Definition="Physical is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("a9474b93-4d66-46a6-9b43-e36368132f93"), Code="Billing", Description="Billing address", Definition="Billing address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("f3bb64e6-7e69-4b73-981b-d0827676c914"), Code="Shipping", Description="Shipping", Definition="Shipping is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("33beba0e-31eb-4c7f-9598-3882457b4ebb"), Code="OnCampus", Description="On campus", Definition="On campus is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("4dbc245c-2c62-4dd7-8b89-1407fbe6a5a5"), Code="OffCampus", Description="Off-campus, temporary", Definition="Off-campus, temporary is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("b89407d0-4f4f-4921-9f58-60764d006788"), Code="PermanentStudent", Description="Permanent, student", Definition="Permanent, student is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("6f9c9d8b-32f8-4920-8f49-b621fec40cd3"), Code="PermanentAdmission", Description="Permanent, at time of admission", Definition="Permanent, at time of admission is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("5250abd7-b32d-4897-a68d-355a1adb99e1"), Code="FatherAddress", Description="Father's address", Definition="Father's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("d932c754-a9c6-4da2-894c-bc0347cc47d2"), Code="MotherAddress", Description="Mother's address", Definition="Mother's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("bcd25b8a-18de-4efc-b4ff-7f5dcf25cde7"), Code="GuardianAddress", Description="Guardian's address", Definition="Guardian's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("2ef0eaf5-d29f-4c09-b30c-537efa206876"), Code="Mailing", Description="Mailing", Definition="Mailing is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("775a6d48-642e-4eca-a03f-6e5598b447d2"), Code="Physical", Description="Physical", Definition="Physical is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("7adfcfbe-a462-4239-ae85-08623649c1cc"), Code="OtherHome", Description="Other home address", Definition="Other home address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("8f7c8a0f-5d64-4124-8151-4b68b19169d8"), Code="Employers", Description="Employer's address", Definition="Employer's address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("5d3d439b-14c2-43c5-ba59-6d4d47d0ad9d"), Code="Employment", Description="Employment address", Definition="Employment address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("392276d7-b912-48a7-90e0-359a72efd62e"), Code="Billing", Description="Billing address", Definition="Billing address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefPersonLocationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPersonLocationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPersonLocationType { Id=Guid.Parse("b6037373-be0c-4132-af0b-b191d7bee6c5"), Description="Mailing", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("40afc1b4-6bd0-4b47-b6d1-77f857034fa2"), Description="Physical", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("a9474b93-4d66-46a6-9b43-e36368132f93"), Description="Billing address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("f3bb64e6-7e69-4b73-981b-d0827676c914"), Description="Shipping", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("33beba0e-31eb-4c7f-9598-3882457b4ebb"), Description="On campus", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("4dbc245c-2c62-4dd7-8b89-1407fbe6a5a5"), Description="Off-campus, temporary", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("b89407d0-4f4f-4921-9f58-60764d006788"), Description="Permanent, student", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("6f9c9d8b-32f8-4920-8f49-b621fec40cd3"), Description="Permanent, at time of admission", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("5250abd7-b32d-4897-a68d-355a1adb99e1"), Description="Father's address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("d932c754-a9c6-4da2-894c-bc0347cc47d2"), Description="Mother's address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("bcd25b8a-18de-4efc-b4ff-7f5dcf25cde7"), Description="Guardian's address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("2ef0eaf5-d29f-4c09-b30c-537efa206876"), Description="Mailing", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("775a6d48-642e-4eca-a03f-6e5598b447d2"), Description="Physical", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("7adfcfbe-a462-4239-ae85-08623649c1cc"), Description="Other home address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("8f7c8a0f-5d64-4124-8151-4b68b19169d8"), Description="Employer's address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("5d3d439b-14c2-43c5-ba59-6d4d47d0ad9d"), Description="Employment address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("392276d7-b912-48a7-90e0-359a72efd62e"), Description="Billing address", SortOrder=Convert.ToDecimal("") },
       };
   }
}
