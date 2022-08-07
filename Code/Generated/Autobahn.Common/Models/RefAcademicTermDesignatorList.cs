//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAcademicTermDesignatorList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAcademicTermDesignator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicTermDesignatorModel"> List
         /// </summary>
        public static List<RefAcademicTermDesignatorModel> RefAcademicTermDesignatorList = new List<RefAcademicTermDesignatorModel>
        {
            new RefAcademicTermDesignator { Id=Guid.Parse("8ef4d5d9-f721-4e51-bc47-fb3b760048e4"), Code="Fall", Description="Fall", Definition="Fall is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("0.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("0ef96c93-864f-47bb-91fd-9ef2a70880e0"), Code="Winter", Description="Winter", Definition="Winter is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("c16bd3ce-09cf-4a36-8520-d825a968fe03"), Code="WinterIntersession", Description="Winter Intersession", Definition="Winter Intersession is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("2028263f-daee-4256-a896-8b18fb691019"), Code="Spring", Description="Spring", Definition="Spring is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("cd463a45-1dcb-40e7-ba3c-7c9d42134b66"), Code="Summer", Description="Summer", Definition="Summer is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("c039703c-5e03-445f-a53d-ca3db6484106"), Code="Summer1", Description="Summer 1", Definition="Summer 1 is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("31bc3197-e457-47fc-b143-c0481b622b4c"), Code="Summer2", Description="Summer 2", Definition="Summer 2 is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("bcbf7d40-47a8-411e-b585-1f71a4f4601e"), Code="SpringIntersession", Description="Spring Intersession", Definition="Spring Intersession is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("a8ccdc5a-5330-4b79-a4ad-0a9306fcbb85"), Code="Other", Description="Other", Definition="Other is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("16.00") },
        };

        /// <summary>
        /// The Reference RefAcademicTermDesignator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAcademicTermDesignatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAcademicTermDesignator { Id=Guid.Parse("8ef4d5d9-f721-4e51-bc47-fb3b760048e4"), Description="Fall", SortOrder=Convert.ToDecimal("0.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("0ef96c93-864f-47bb-91fd-9ef2a70880e0"), Description="Winter", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("c16bd3ce-09cf-4a36-8520-d825a968fe03"), Description="Winter Intersession", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("2028263f-daee-4256-a896-8b18fb691019"), Description="Spring", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("cd463a45-1dcb-40e7-ba3c-7c9d42134b66"), Description="Summer", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("c039703c-5e03-445f-a53d-ca3db6484106"), Description="Summer 1", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("31bc3197-e457-47fc-b143-c0481b622b4c"), Description="Summer 2", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("bcbf7d40-47a8-411e-b585-1f71a4f4601e"), Description="Spring Intersession", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("a8ccdc5a-5330-4b79-a4ad-0a9306fcbb85"), Description="Other", SortOrder=Convert.ToDecimal("16.00") },
       };
   }
}
