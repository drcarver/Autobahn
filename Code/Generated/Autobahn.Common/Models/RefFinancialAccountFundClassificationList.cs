//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAccountFundClassificationList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialAccountFundClassification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAccountFundClassificationModel"> List
         /// </summary>
        public static List<RefFinancialAccountFundClassificationModel> RefFinancialAccountFundClassificationList = new List<RefFinancialAccountFundClassificationModel>
        {
            new RefFinancialAccountFundClassification { Id=Guid.Parse("1bbd8b2c-e5b6-414e-a9b0-1894f2d85ce3"), Code="1", Description="General Fund", Definition="General Fund financial account.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("6f04ee14-5a97-49b6-bade-b1b9e3da12fb"), Code="2", Description="Special Revenue Funds", Definition="Special Revenue Funds financial account.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("3cbbedd8-b406-4282-b430-a507ca3abb41"), Code="3", Description="Capital Projects Funds", Definition="Capital Projects Funds financial account.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("bb051eb4-36a5-4a25-b963-5aaaa66caf6f"), Code="4", Description="Debt Service Funds", Definition="Debt Service Funds financial account.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("4a5e3a90-b06d-4fe5-a52b-1ad8a1790f22"), Code="5", Description="Permanent Funds", Definition="Permanent Funds financial account.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("4daaf50b-ead4-4fae-8ba1-428370fe3231"), Code="6", Description="Enterprise Funds", Definition="Enterprise Funds financial account.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("22e9b3eb-fc08-4f8d-844d-7aa437c65c24"), Code="7", Description="Internal Service Funds", Definition="Internal Service Funds financial account.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("379fa155-c1cc-4d76-8328-020608e25611"), Code="8", Description="Trust Funds", Definition="Trust Funds financial account.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("82d1e3dc-16ab-4275-8556-9e44dc6c2ff0"), Code="9", Description="Agency Funds", Definition="Agency Funds financial account.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefFinancialAccountFundClassification Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFinancialAccountFundClassificationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFinancialAccountFundClassification { Id=Guid.Parse("1bbd8b2c-e5b6-414e-a9b0-1894f2d85ce3"), Description="General Fund", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("6f04ee14-5a97-49b6-bade-b1b9e3da12fb"), Description="Special Revenue Funds", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("3cbbedd8-b406-4282-b430-a507ca3abb41"), Description="Capital Projects Funds", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("bb051eb4-36a5-4a25-b963-5aaaa66caf6f"), Description="Debt Service Funds", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("4a5e3a90-b06d-4fe5-a52b-1ad8a1790f22"), Description="Permanent Funds", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("4daaf50b-ead4-4fae-8ba1-428370fe3231"), Description="Enterprise Funds", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("22e9b3eb-fc08-4f8d-844d-7aa437c65c24"), Description="Internal Service Funds", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("379fa155-c1cc-4d76-8328-020608e25611"), Description="Trust Funds", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("82d1e3dc-16ab-4275-8556-9e44dc6c2ff0"), Description="Agency Funds", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
