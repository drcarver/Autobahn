//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAidAwardTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialAidAwardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAidAwardTypeModel"> List
         /// </summary>
        public static List<RefFinancialAidAwardTypeModel> RefFinancialAidAwardTypeList = new List<RefFinancialAidAwardTypeModel>
        {
            new RefFinancialAidAwardType { Id=Guid.Parse("6415225e-ebac-49e0-945b-fdf8fc48a3df"), Code="PellGrants", Description="Pell grants", Definition="Pell grants", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("9ded4102-ead3-431f-9066-8ebbc5492e6c"), Code="OtherFederalGrants", Description="Other federal grants", Definition="Other federal grants", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("d2254fd0-ea30-40ff-9544-12c0ae570aad"), Code="StateAndLocalGrants", Description="State and local grants", Definition="State and local grants", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("9df5a73b-6c4f-4d17-9e71-2b2fc8a41031"), Code="InstitutionalGrants", Description="Institutional grants", Definition="Institutional grants", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("cfccd068-0481-402c-99f5-03bd9e3ce105"), Code="PrivateGrants", Description="Private grants", Definition="Private grants", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("cda98d05-a26a-4670-a2ba-65a576c65870"), Code="OtherGrants", Description="Other grants", Definition="Other grants", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("11a848f3-94c2-49fc-b224-8c6e7f5c49be"), Code="Assistantships", Description="Assistantships", Definition="Assistantships", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("914b47dd-88ce-400c-bd61-4c200ff566cd"), Code="FederalScholarships", Description="Federal scholarships", Definition="Federal scholarships", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("3feef899-ea38-473d-90d7-39d4e82e27a6"), Code="StateAndLocalScholarships", Description="State and local scholarships", Definition="State and local scholarships", SortOrder=Convert.ToDecimal("9.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("1086310f-19bd-45c2-af14-82b20958e09a"), Code="InstitutionalScholarships", Description="Institutional scholarships", Definition="Institutional scholarships", SortOrder=Convert.ToDecimal("10.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("2e851b12-21bf-40c9-a678-9e9f1b829bbd"), Code="PrivateScholarships", Description="Private scholarships", Definition="Private scholarships", SortOrder=Convert.ToDecimal("11.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("10e7fda1-688b-4391-8259-25d470c1c289"), Code="OtherScholarships", Description="Other scholarships", Definition="Other scholarships", SortOrder=Convert.ToDecimal("12.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("98d4a4a1-5582-417c-b70f-1b61623ae37b"), Code="FederalSubsidizedLoans", Description="Federal subsidized loans", Definition="Federal subsidized loans", SortOrder=Convert.ToDecimal("13.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("e8191b37-e469-4bd0-a3b3-4a6ab79fb8ef"), Code="FederalUnsubsidizedLoans", Description="Federal unsubsidized loans", Definition="Federal unsubsidized loans", SortOrder=Convert.ToDecimal("14.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("ca28db61-5457-4665-89cc-8325d023eb3f"), Code="PrivateLoans", Description="Private loans", Definition="Private loans", SortOrder=Convert.ToDecimal("15.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("1d266cb5-4ab9-41a6-a701-33e0cf29a6bf"), Code="StateLoans", Description="State loans", Definition="State loans", SortOrder=Convert.ToDecimal("16.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("42276b2a-b779-4768-b981-56ed0ca70ebb"), Code="InstitutionalLoans", Description="Institutional loans", Definition="Institutional loans", SortOrder=Convert.ToDecimal("17.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("535be765-fce4-4ebe-9dd1-ccbed69fb290"), Code="ParentPLUSLoans", Description="Parent PLUS loans", Definition="Parent PLUS loans", SortOrder=Convert.ToDecimal("18.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("3ce8560e-07c4-4a72-902f-afadbafe6d58"), Code="OtherLoans", Description="Other loans", Definition="Other loans", SortOrder=Convert.ToDecimal("19.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("bdcca51b-a7c8-4dd7-bd94-a7da6f6ec61c"), Code="StateWork", Description="State work", Definition="State work", SortOrder=Convert.ToDecimal("19.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("d82bdb8a-bd28-4647-a1fe-2c07ba477340"), Code="FederalWorkStudy", Description="Federal work study", Definition="Federal work study", SortOrder=Convert.ToDecimal("20.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("bd3f7345-e9c1-4053-a37c-376a51799989"), Code="OtherOnCampusWork", Description="Other on-campus work", Definition="Other on-campus work", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The Reference RefFinancialAidAwardType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFinancialAidAwardTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFinancialAidAwardType { Id=Guid.Parse("6415225e-ebac-49e0-945b-fdf8fc48a3df"), Description="Pell grants", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("9ded4102-ead3-431f-9066-8ebbc5492e6c"), Description="Other federal grants", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("d2254fd0-ea30-40ff-9544-12c0ae570aad"), Description="State and local grants", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("9df5a73b-6c4f-4d17-9e71-2b2fc8a41031"), Description="Institutional grants", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("cfccd068-0481-402c-99f5-03bd9e3ce105"), Description="Private grants", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("cda98d05-a26a-4670-a2ba-65a576c65870"), Description="Other grants", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("11a848f3-94c2-49fc-b224-8c6e7f5c49be"), Description="Assistantships", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("914b47dd-88ce-400c-bd61-4c200ff566cd"), Description="Federal scholarships", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("3feef899-ea38-473d-90d7-39d4e82e27a6"), Description="State and local scholarships", SortOrder=Convert.ToDecimal("9.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("1086310f-19bd-45c2-af14-82b20958e09a"), Description="Institutional scholarships", SortOrder=Convert.ToDecimal("10.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("2e851b12-21bf-40c9-a678-9e9f1b829bbd"), Description="Private scholarships", SortOrder=Convert.ToDecimal("11.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("10e7fda1-688b-4391-8259-25d470c1c289"), Description="Other scholarships", SortOrder=Convert.ToDecimal("12.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("98d4a4a1-5582-417c-b70f-1b61623ae37b"), Description="Federal subsidized loans", SortOrder=Convert.ToDecimal("13.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("e8191b37-e469-4bd0-a3b3-4a6ab79fb8ef"), Description="Federal unsubsidized loans", SortOrder=Convert.ToDecimal("14.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("ca28db61-5457-4665-89cc-8325d023eb3f"), Description="Private loans", SortOrder=Convert.ToDecimal("15.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("1d266cb5-4ab9-41a6-a701-33e0cf29a6bf"), Description="State loans", SortOrder=Convert.ToDecimal("16.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("42276b2a-b779-4768-b981-56ed0ca70ebb"), Description="Institutional loans", SortOrder=Convert.ToDecimal("17.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("535be765-fce4-4ebe-9dd1-ccbed69fb290"), Description="Parent PLUS loans", SortOrder=Convert.ToDecimal("18.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("3ce8560e-07c4-4a72-902f-afadbafe6d58"), Description="Other loans", SortOrder=Convert.ToDecimal("19.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("bdcca51b-a7c8-4dd7-bd94-a7da6f6ec61c"), Description="State work", SortOrder=Convert.ToDecimal("19.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("d82bdb8a-bd28-4647-a1fe-2c07ba477340"), Description="Federal work study", SortOrder=Convert.ToDecimal("20.00") },
            new RefFinancialAidAwardType { Id=Guid.Parse("bd3f7345-e9c1-4053-a37c-376a51799989"), Description="Other on-campus work", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
