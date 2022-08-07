//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAidApplicationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialAidApplicationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAidApplicationTypeModel"> List
         /// </summary>
        public static List<RefFinancialAidApplicationTypeModel> RefFinancialAidApplicationTypeList = new List<RefFinancialAidApplicationTypeModel>
        {
            new RefFinancialAidApplicationType { Id=Guid.Parse("0872386a-ae91-49f5-a05c-307340231bec"), Code="FAFSA", Description="Free Application for Federal Student Aid (FAFSA)", Definition="Free Application for Federal Student Aid (FAFSA)", SortOrder=Convert.ToDecimal("0.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("17820ab9-1849-4670-82e2-ef48c3906908"), Code="StateApplication", Description="State Application", Definition="State Application", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("93294249-3a54-4b25-8fd5-4a71049a7f1a"), Code="InstitutionApplication", Description="Institution Application", Definition="Institution Application", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("fab58834-673d-401e-acef-ec8b83115832"), Code="Other", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("52f1b5cb-770c-4a7a-a566-27778f8782e5"), Code="None", Description="None", Definition="None", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefFinancialAidApplicationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFinancialAidApplicationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFinancialAidApplicationType { Id=Guid.Parse("0872386a-ae91-49f5-a05c-307340231bec"), Description="Free Application for Federal Student Aid (FAFSA)", SortOrder=Convert.ToDecimal("0.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("17820ab9-1849-4670-82e2-ef48c3906908"), Description="State Application", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("93294249-3a54-4b25-8fd5-4a71049a7f1a"), Description="Institution Application", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("fab58834-673d-401e-acef-ec8b83115832"), Description="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAidApplicationType { Id=Guid.Parse("52f1b5cb-770c-4a7a-a566-27778f8782e5"), Description="None", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
