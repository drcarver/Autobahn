//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefServiceFrequencyList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefServiceFrequency Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefServiceFrequencyModel"> List
         /// </summary>
        public static List<RefServiceFrequencyModel> RefServiceFrequencyList = new List<RefServiceFrequencyModel>
        {
            new RefServiceFrequency { Id=Guid.Parse("4b927d94-26d1-48c1-b3b5-4d1b3b1627be"), Code="Daily", Description="Daily", Definition="The service is planned to be provided Daily.", SortOrder=Convert.ToDecimal("2.00") },
            new RefServiceFrequency { Id=Guid.Parse("5ed0646b-7ab0-4629-88af-d1585646778c"), Code="Weekly", Description="Weekly", Definition="The service is planned to be provided Weekly.", SortOrder=Convert.ToDecimal("4.00") },
            new RefServiceFrequency { Id=Guid.Parse("9606092b-a1a0-44f4-9e09-91ab841a15bb"), Code="Biweekly", Description="Biweekly", Definition="The service is planned to be provided Biweekly.", SortOrder=Convert.ToDecimal("6.00") },
            new RefServiceFrequency { Id=Guid.Parse("788cf032-4f71-43d5-b41b-bb3861b7cfde"), Code="Monthly", Description="Monthly", Definition="The service is planned to be provided Monthly.", SortOrder=Convert.ToDecimal("8.00") },
            new RefServiceFrequency { Id=Guid.Parse("98f30c75-e7e9-4dbe-990f-e302788ce054"), Code="Bimonthly", Description="Bimonthly", Definition="The service is planned to be provided Bimonthly.", SortOrder=Convert.ToDecimal("10.00") },
            new RefServiceFrequency { Id=Guid.Parse("d21c500e-96d3-4eae-9bde-56a651c6d3e3"), Code="Quarterly", Description="Quarterly", Definition="The service is planned to be provided Quarterly.", SortOrder=Convert.ToDecimal("12.00") },
            new RefServiceFrequency { Id=Guid.Parse("87f0e6a6-c712-43c2-977f-902cffa4c809"), Code="Semiannually", Description="Semiannually", Definition="The service is planned to be provided Semiannually.", SortOrder=Convert.ToDecimal("14.00") },
            new RefServiceFrequency { Id=Guid.Parse("6cb835e3-f7f2-42c5-a1bb-cbe5b9487001"), Code="Annually", Description="Annually", Definition="The service is planned to be provided Annually.", SortOrder=Convert.ToDecimal("16.00") },
            new RefServiceFrequency { Id=Guid.Parse("8fe78b6c-fc05-4217-9ca6-4acc964f12f5"), Code="Other", Description="Other", Definition="The service is planned to be provided at a frequency not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefServiceFrequency Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefServiceFrequencyViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefServiceFrequency { Id=Guid.Parse("4b927d94-26d1-48c1-b3b5-4d1b3b1627be"), Description="Daily", SortOrder=Convert.ToDecimal("2.00") },
            new RefServiceFrequency { Id=Guid.Parse("5ed0646b-7ab0-4629-88af-d1585646778c"), Description="Weekly", SortOrder=Convert.ToDecimal("4.00") },
            new RefServiceFrequency { Id=Guid.Parse("9606092b-a1a0-44f4-9e09-91ab841a15bb"), Description="Biweekly", SortOrder=Convert.ToDecimal("6.00") },
            new RefServiceFrequency { Id=Guid.Parse("788cf032-4f71-43d5-b41b-bb3861b7cfde"), Description="Monthly", SortOrder=Convert.ToDecimal("8.00") },
            new RefServiceFrequency { Id=Guid.Parse("98f30c75-e7e9-4dbe-990f-e302788ce054"), Description="Bimonthly", SortOrder=Convert.ToDecimal("10.00") },
            new RefServiceFrequency { Id=Guid.Parse("d21c500e-96d3-4eae-9bde-56a651c6d3e3"), Description="Quarterly", SortOrder=Convert.ToDecimal("12.00") },
            new RefServiceFrequency { Id=Guid.Parse("87f0e6a6-c712-43c2-977f-902cffa4c809"), Description="Semiannually", SortOrder=Convert.ToDecimal("14.00") },
            new RefServiceFrequency { Id=Guid.Parse("6cb835e3-f7f2-42c5-a1bb-cbe5b9487001"), Description="Annually", SortOrder=Convert.ToDecimal("16.00") },
            new RefServiceFrequency { Id=Guid.Parse("8fe78b6c-fc05-4217-9ca6-4acc964f12f5"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
