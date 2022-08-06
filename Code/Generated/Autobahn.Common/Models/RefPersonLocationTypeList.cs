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
        public static List<RefPersonLocationType> RefPersonLocationTypeList = new List<RefPersonLocationType> =
        {
            new RefPersonLocationType { Id=Guid.Parse("b596c1cb-2daf-4883-81f9-56ce934c7981"), Code="Mailing is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="Mailing", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("71c48816-2558-4846-ab1d-c9c5b1ca67d2"), Code="Physical is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="Physical", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("9cdc47a8-fa42-42c2-afea-5fb2da0d91a8"), Code="Billing address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="Billing", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("dfe29d23-c2ac-4c01-8963-c5db1382e737"), Code="Shipping is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="Shipping", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("769ba81a-bfaa-4ed0-962f-38046bf59bea"), Code="On campus is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="OnCampus", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("e4650219-7fdc-40a1-9ee9-b887d2ac50f8"), Code="Off-campus, temporary is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="OffCampus", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("81642838-9921-49a1-8387-49eee5c3993e"), Code="Permanent, student is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="PermanentStudent", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("e965ddc4-d41e-44e5-b51e-7540650472f7"), Code="Permanent, at time of admission is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="PermanentAdmission", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("04391cbf-d857-498b-91d5-5ee49be4acc2"), Code="Father's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="FatherAddress", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("64407132-a97d-4af7-adfd-7780d83af93a"), Code="Mother's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="MotherAddress", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("1d3ccf45-0b4f-44b4-bfb5-dd756b89d9c2"), Code="Guardian's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", Description="GuardianAddress", Definition="", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("01924b7f-c8a4-4073-b682-c464a674fbce"), Code="Mailing is specified as the address type for a staff member.", Description="Mailing", Definition="", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("fe8b9917-41e8-4802-a2e6-062e2907cf3a"), Code="Physical is specified as the address type for a staff member.", Description="Physical", Definition="", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("86bc0694-d60c-4bb8-a294-a076876eb980"), Code="Other home address is specified as the address type for a staff member.", Description="OtherHome", Definition="", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("2fc58867-0bc6-42ad-82dd-e7ced9ce75e6"), Code="Employer's address is specified as the address type for a staff member.", Description="Employers", Definition="", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("aa4d8c0b-f519-432f-907a-5be55bbe2ba6"), Code="Employment address is specified as the address type for a staff member.", Description="Employment", Definition="", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("86216fd3-69d1-455e-9d29-8715ef01d595"), Code="Billing address is specified as the address type for a staff member.", Description="Billing", Definition="", SortOrder=2 },
        };

        /// <summary>
        /// The RefPersonLocationType Pick List
         /// </summary>
        public static List<RefPersonLocationType> RefPersonLocationTypePickList = new List<RefPersonLocationType> =
        {
            new RefPersonLocationType { Id=Guid.Parse("b596c1cb-2daf-4883-81f9-56ce934c7981"), Code="Mailing is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("71c48816-2558-4846-ab1d-c9c5b1ca67d2"), Code="Physical is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("9cdc47a8-fa42-42c2-afea-5fb2da0d91a8"), Code="Billing address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("dfe29d23-c2ac-4c01-8963-c5db1382e737"), Code="Shipping is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("769ba81a-bfaa-4ed0-962f-38046bf59bea"), Code="On campus is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("e4650219-7fdc-40a1-9ee9-b887d2ac50f8"), Code="Off-campus, temporary is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("81642838-9921-49a1-8387-49eee5c3993e"), Code="Permanent, student is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("e965ddc4-d41e-44e5-b51e-7540650472f7"), Code="Permanent, at time of admission is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("04391cbf-d857-498b-91d5-5ee49be4acc2"), Code="Father's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("64407132-a97d-4af7-adfd-7780d83af93a"), Code="Mother's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("1d3ccf45-0b4f-44b4-bfb5-dd756b89d9c2"), Code="Guardian's address is specified as the type of address listed for a learner or a parent, guardian, family member or related person.", SortOrder=1 },
            new RefPersonLocationType { Id=Guid.Parse("01924b7f-c8a4-4073-b682-c464a674fbce"), Code="Mailing is specified as the address type for a staff member.", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("fe8b9917-41e8-4802-a2e6-062e2907cf3a"), Code="Physical is specified as the address type for a staff member.", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("86bc0694-d60c-4bb8-a294-a076876eb980"), Code="Other home address is specified as the address type for a staff member.", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("2fc58867-0bc6-42ad-82dd-e7ced9ce75e6"), Code="Employer's address is specified as the address type for a staff member.", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("aa4d8c0b-f519-432f-907a-5be55bbe2ba6"), Code="Employment address is specified as the address type for a staff member.", SortOrder=2 },
            new RefPersonLocationType { Id=Guid.Parse("86216fd3-69d1-455e-9d29-8715ef01d595"), Code="Billing address is specified as the address type for a staff member.", SortOrder=2 },
       };
   }
}
