//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProgramSponsorTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProgramSponsorType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgramSponsorTypeModel"> List
         /// </summary>
        public static List<RefProgramSponsorTypeModel> RefProgramSponsorTypeList = new List<RefProgramSponsorTypeModel>
        {
            new RefProgramSponsorType { Id=Guid.Parse("521f228e-2959-4ceb-b659-e2e66cd89364"), Code="Business", Description="Business", Definition="A business is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramSponsorType { Id=Guid.Parse("d724abe4-9f06-4c92-b184-26da3a77a9b4"), Code="EducationOrganizationNetwork", Description="Education organization network", Definition="An education organization network is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramSponsorType { Id=Guid.Parse("53e44024-22f2-49f8-b693-96199d74d835"), Code="EducationServiceCenter", Description="Education Service Center", Definition="An education Service Center is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("3.00") },
            new RefProgramSponsorType { Id=Guid.Parse("411852be-552e-4f60-a97b-d9fa6c34f63c"), Code="Federal", Description="Federal government", Definition="The federal government is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgramSponsorType { Id=Guid.Parse("aa9220c0-c093-40c1-b84b-85d032ae1eb7"), Code="LEA", Description="Local education agency", Definition="The local education agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("5.00") },
            new RefProgramSponsorType { Id=Guid.Parse("d25d4009-3104-432e-90a0-bd417be96793"), Code="NonProfit", Description="Non-profit organization", Definition="A non-profit organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("7.00") },
            new RefProgramSponsorType { Id=Guid.Parse("00ef48f7-1e1d-4a8c-8b2e-6f6f3b66b2de"), Code="Postsecondary", Description="Postsecondary institution", Definition="A postsecondary institution is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("9.00") },
            new RefProgramSponsorType { Id=Guid.Parse("84ce12ec-98e5-4165-8f10-0ae0684cd7c3"), Code="Private", Description="Private organization", Definition="A private organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("11.00") },
            new RefProgramSponsorType { Id=Guid.Parse("865285bb-bb2e-47a8-848d-96bbd27b89ea"), Code="Regional", Description="Regional or intermediate education agency", Definition="A regional or intermediate education agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("13.00") },
            new RefProgramSponsorType { Id=Guid.Parse("82ca83d5-df06-4b30-82df-5eb0be48f9a7"), Code="Religious", Description="Religious organization", Definition="A religious organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("15.00") },
            new RefProgramSponsorType { Id=Guid.Parse("baa61d6d-3d4b-48e0-873c-d06915746d12"), Code="School", Description="School", Definition="The school is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("17.00") },
            new RefProgramSponsorType { Id=Guid.Parse("997fc209-289c-46e7-8277-9521c1bfc93f"), Code="SEA", Description="State Education Agency", Definition="The State Education Agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("19.00") },
            new RefProgramSponsorType { Id=Guid.Parse("f7218b6e-ccda-485e-bd2e-5b6258deec1e"), Code="Other", Description="Other", Definition="The category of organization providing funds for the particular educational or service program or activity or for an individual's participation in the program or activity is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The Reference RefProgramSponsorType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefProgramSponsorTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefProgramSponsorType { Id=Guid.Parse("521f228e-2959-4ceb-b659-e2e66cd89364"), Description="Business", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramSponsorType { Id=Guid.Parse("d724abe4-9f06-4c92-b184-26da3a77a9b4"), Description="Education organization network", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramSponsorType { Id=Guid.Parse("53e44024-22f2-49f8-b693-96199d74d835"), Description="Education Service Center", SortOrder=Convert.ToDecimal("3.00") },
            new RefProgramSponsorType { Id=Guid.Parse("411852be-552e-4f60-a97b-d9fa6c34f63c"), Description="Federal government", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgramSponsorType { Id=Guid.Parse("aa9220c0-c093-40c1-b84b-85d032ae1eb7"), Description="Local education agency", SortOrder=Convert.ToDecimal("5.00") },
            new RefProgramSponsorType { Id=Guid.Parse("d25d4009-3104-432e-90a0-bd417be96793"), Description="Non-profit organization", SortOrder=Convert.ToDecimal("7.00") },
            new RefProgramSponsorType { Id=Guid.Parse("00ef48f7-1e1d-4a8c-8b2e-6f6f3b66b2de"), Description="Postsecondary institution", SortOrder=Convert.ToDecimal("9.00") },
            new RefProgramSponsorType { Id=Guid.Parse("84ce12ec-98e5-4165-8f10-0ae0684cd7c3"), Description="Private organization", SortOrder=Convert.ToDecimal("11.00") },
            new RefProgramSponsorType { Id=Guid.Parse("865285bb-bb2e-47a8-848d-96bbd27b89ea"), Description="Regional or intermediate education agency", SortOrder=Convert.ToDecimal("13.00") },
            new RefProgramSponsorType { Id=Guid.Parse("82ca83d5-df06-4b30-82df-5eb0be48f9a7"), Description="Religious organization", SortOrder=Convert.ToDecimal("15.00") },
            new RefProgramSponsorType { Id=Guid.Parse("baa61d6d-3d4b-48e0-873c-d06915746d12"), Description="School", SortOrder=Convert.ToDecimal("17.00") },
            new RefProgramSponsorType { Id=Guid.Parse("997fc209-289c-46e7-8277-9521c1bfc93f"), Description="State Education Agency", SortOrder=Convert.ToDecimal("19.00") },
            new RefProgramSponsorType { Id=Guid.Parse("f7218b6e-ccda-485e-bd2e-5b6258deec1e"), Description="Other", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
