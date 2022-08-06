//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonLocationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPersonLocationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPersonLocationType"> List
         /// </summary>
        public static List<RefPersonLocationType> RefPersonLocationTypeList = new List<RefPersonLocationType>
        {
            new RefPersonLocationType { Id=Guid.Parse("f153c1a8-3cc7-42d6-9eaa-b37bc717af95"), Code="Mailing", Description="Mailing", Definition="Mailing is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("530aa16f-f3ed-4ed7-bfdf-cf3c638b8dbb"), Code="Physical", Description="Physical", Definition="Physical is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("2527db7b-42cf-444d-bb70-10b9253e5bc1"), Code="Billing", Description="Billing address", Definition="Billing address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("6c529bd1-f2b7-4fef-b572-49b83654c141"), Code="Shipping", Description="Shipping", Definition="Shipping is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("0da30015-a3da-426c-936c-0145f5632884"), Code="OnCampus", Description="On campus", Definition="On campus is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("99955abf-ecf4-4da0-817b-2ed4676fc8d2"), Code="OffCampus", Description="Off-campus, temporary", Definition="Off-campus, temporary is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("738327ab-1093-4e42-b075-1a1922487646"), Code="PermanentStudent", Description="Permanent, student", Definition="Permanent, student is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("0c8862dc-cab6-48a6-8a18-c5ac38ff17e7"), Code="PermanentAdmission", Description="Permanent, at time of admission", Definition="Permanent, at time of admission is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("e3d7ca30-3244-4d64-b2f8-18d8d185e7cb"), Code="FatherAddress", Description="Father's address", Definition="Father's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("91d9c343-8c72-4176-956d-153170bda59c"), Code="MotherAddress", Description="Mother's address", Definition="Mother's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("e4e1c60c-e852-49bf-b244-053bfbee00de"), Code="GuardianAddress", Description="Guardian's address", Definition="Guardian's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("de631219-b1f0-4998-a790-33528b76923d"), Code="Mailing", Description="Mailing", Definition="Mailing is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("52bfd260-01cf-4c63-b093-e35a7b8139b1"), Code="Physical", Description="Physical", Definition="Physical is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("e90d45c2-fa91-4581-ba81-a3345bdec4f9"), Code="OtherHome", Description="Other home address", Definition="Other home address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("1492a066-f42b-4554-92b6-3a0f9f675968"), Code="Employers", Description="Employer's address", Definition="Employer's address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("63c5d018-6171-4106-b977-fa9bd4be47b1"), Code="Employment", Description="Employment address", Definition="Employment address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("4557208e-1ace-45fe-aa54-b1618f6f2887"), Code="Billing", Description="Billing address", Definition="Billing address is specified as the address type for a staff member.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefPersonLocationType Pick List
         /// </summary>
        public static List<RefPersonLocationType> RefPersonLocationTypePickList = new List<RefPersonLocationType>
        {
            new RefPersonLocationType { Id=Guid.Parse("f153c1a8-3cc7-42d6-9eaa-b37bc717af95"), Code="Mailing", Description="Mailing", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("530aa16f-f3ed-4ed7-bfdf-cf3c638b8dbb"), Code="Physical", Description="Physical", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("2527db7b-42cf-444d-bb70-10b9253e5bc1"), Code="Billing", Description="Billing address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("6c529bd1-f2b7-4fef-b572-49b83654c141"), Code="Shipping", Description="Shipping", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("0da30015-a3da-426c-936c-0145f5632884"), Code="OnCampus", Description="On campus", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("99955abf-ecf4-4da0-817b-2ed4676fc8d2"), Code="OffCampus", Description="Off-campus, temporary", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("738327ab-1093-4e42-b075-1a1922487646"), Code="PermanentStudent", Description="Permanent, student", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("0c8862dc-cab6-48a6-8a18-c5ac38ff17e7"), Code="PermanentAdmission", Description="Permanent, at time of admission", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("e3d7ca30-3244-4d64-b2f8-18d8d185e7cb"), Code="FatherAddress", Description="Father's address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("91d9c343-8c72-4176-956d-153170bda59c"), Code="MotherAddress", Description="Mother's address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("e4e1c60c-e852-49bf-b244-053bfbee00de"), Code="GuardianAddress", Description="Guardian's address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("de631219-b1f0-4998-a790-33528b76923d"), Code="Mailing", Description="Mailing", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("52bfd260-01cf-4c63-b093-e35a7b8139b1"), Code="Physical", Description="Physical", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("e90d45c2-fa91-4581-ba81-a3345bdec4f9"), Code="OtherHome", Description="Other home address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("1492a066-f42b-4554-92b6-3a0f9f675968"), Code="Employers", Description="Employer's address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("63c5d018-6171-4106-b977-fa9bd4be47b1"), Code="Employment", Description="Employment address", SortOrder=Convert.ToDecimal("") },
            new RefPersonLocationType { Id=Guid.Parse("4557208e-1ace-45fe-aa54-b1618f6f2887"), Code="Billing", Description="Billing address", SortOrder=Convert.ToDecimal("") },
       };
   }
}
