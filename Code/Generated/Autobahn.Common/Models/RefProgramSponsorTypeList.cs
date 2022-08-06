//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProgramSponsorTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProgramSponsorType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgramSponsorType"> List
         /// </summary>
        public static List<RefProgramSponsorType> RefProgramSponsorTypeList = new List<RefProgramSponsorType>
        {
            new RefProgramSponsorType { Id=Guid.Parse("5e60c0cd-e32b-4b3b-93b5-b25bcc5ab9ed"), Code="Business", Description="Business", Definition="A business is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramSponsorType { Id=Guid.Parse("5ca7131b-7ec0-445a-b2f1-f3a8de8e0cbc"), Code="EducationOrganizationNetwork", Description="Education organization network", Definition="An education organization network is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramSponsorType { Id=Guid.Parse("04b9debd-c0d0-464e-a2fb-86f5b645ab9e"), Code="EducationServiceCenter", Description="Education Service Center", Definition="An education Service Center is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("3.00") },
            new RefProgramSponsorType { Id=Guid.Parse("51b640d1-d735-4d66-bf4d-37edd7e75c0b"), Code="Federal", Description="Federal government", Definition="The federal government is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgramSponsorType { Id=Guid.Parse("0f625cf3-2aee-4b7b-b813-86ff1c79193a"), Code="LEA", Description="Local education agency", Definition="The local education agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("5.00") },
            new RefProgramSponsorType { Id=Guid.Parse("9a140260-e6d3-41eb-8a1b-f9b75685d3b0"), Code="NonProfit", Description="Non-profit organization", Definition="A non-profit organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("7.00") },
            new RefProgramSponsorType { Id=Guid.Parse("d52e9e1b-ed02-4e1b-b77f-5d9d5179e524"), Code="Postsecondary", Description="Postsecondary institution", Definition="A postsecondary institution is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("9.00") },
            new RefProgramSponsorType { Id=Guid.Parse("68249c60-1b2b-418c-8b2c-dda2911e4b9a"), Code="Private", Description="Private organization", Definition="A private organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("11.00") },
            new RefProgramSponsorType { Id=Guid.Parse("9425a346-8ec6-4252-9103-fbfa5303a3d9"), Code="Regional", Description="Regional or intermediate education agency", Definition="A regional or intermediate education agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("13.00") },
            new RefProgramSponsorType { Id=Guid.Parse("4c4dfba2-b546-47c1-bf99-8fe76be5ba69"), Code="Religious", Description="Religious organization", Definition="A religious organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("15.00") },
            new RefProgramSponsorType { Id=Guid.Parse("a0497c44-d82a-452f-8183-f74620a459d7"), Code="School", Description="School", Definition="The school is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("17.00") },
            new RefProgramSponsorType { Id=Guid.Parse("0aa0e945-005e-4cdd-83d0-9009bc1d1692"), Code="SEA", Description="State Education Agency", Definition="The State Education Agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("19.00") },
            new RefProgramSponsorType { Id=Guid.Parse("274026e4-bcf3-47b2-ba7e-a85e61c52dfc"), Code="Other", Description="Other", Definition="The category of organization providing funds for the particular educational or service program or activity or for an individual's participation in the program or activity is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The RefProgramSponsorType Pick List
         /// </summary>
        public static List<RefProgramSponsorType> RefProgramSponsorTypePickList = new List<RefProgramSponsorType>
        {
            new RefProgramSponsorType { Id=Guid.Parse("5e60c0cd-e32b-4b3b-93b5-b25bcc5ab9ed"), Code="Business", Description="Business", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramSponsorType { Id=Guid.Parse("5ca7131b-7ec0-445a-b2f1-f3a8de8e0cbc"), Code="EducationOrganizationNetwork", Description="Education organization network", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramSponsorType { Id=Guid.Parse("04b9debd-c0d0-464e-a2fb-86f5b645ab9e"), Code="EducationServiceCenter", Description="Education Service Center", SortOrder=Convert.ToDecimal("3.00") },
            new RefProgramSponsorType { Id=Guid.Parse("51b640d1-d735-4d66-bf4d-37edd7e75c0b"), Code="Federal", Description="Federal government", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgramSponsorType { Id=Guid.Parse("0f625cf3-2aee-4b7b-b813-86ff1c79193a"), Code="LEA", Description="Local education agency", SortOrder=Convert.ToDecimal("5.00") },
            new RefProgramSponsorType { Id=Guid.Parse("9a140260-e6d3-41eb-8a1b-f9b75685d3b0"), Code="NonProfit", Description="Non-profit organization", SortOrder=Convert.ToDecimal("7.00") },
            new RefProgramSponsorType { Id=Guid.Parse("d52e9e1b-ed02-4e1b-b77f-5d9d5179e524"), Code="Postsecondary", Description="Postsecondary institution", SortOrder=Convert.ToDecimal("9.00") },
            new RefProgramSponsorType { Id=Guid.Parse("68249c60-1b2b-418c-8b2c-dda2911e4b9a"), Code="Private", Description="Private organization", SortOrder=Convert.ToDecimal("11.00") },
            new RefProgramSponsorType { Id=Guid.Parse("9425a346-8ec6-4252-9103-fbfa5303a3d9"), Code="Regional", Description="Regional or intermediate education agency", SortOrder=Convert.ToDecimal("13.00") },
            new RefProgramSponsorType { Id=Guid.Parse("4c4dfba2-b546-47c1-bf99-8fe76be5ba69"), Code="Religious", Description="Religious organization", SortOrder=Convert.ToDecimal("15.00") },
            new RefProgramSponsorType { Id=Guid.Parse("a0497c44-d82a-452f-8183-f74620a459d7"), Code="School", Description="School", SortOrder=Convert.ToDecimal("17.00") },
            new RefProgramSponsorType { Id=Guid.Parse("0aa0e945-005e-4cdd-83d0-9009bc1d1692"), Code="SEA", Description="State Education Agency", SortOrder=Convert.ToDecimal("19.00") },
            new RefProgramSponsorType { Id=Guid.Parse("274026e4-bcf3-47b2-ba7e-a85e61c52dfc"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
