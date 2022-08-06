//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAccountFundClassificationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialAccountFundClassification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAccountFundClassification"> List
         /// </summary>
        public static List<RefFinancialAccountFundClassification> RefFinancialAccountFundClassificationList = new List<RefFinancialAccountFundClassification>
        {
            new RefFinancialAccountFundClassification { Id=Guid.Parse("81689c0b-b858-4d82-9d37-be1fa90d2021"), Code="1", Description="General Fund", Definition="General Fund financial account.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("8f3d9fd3-42f0-4a43-afac-d1529fb424ef"), Code="2", Description="Special Revenue Funds", Definition="Special Revenue Funds financial account.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("f07398eb-a88e-4727-aeda-34ede54c07dc"), Code="3", Description="Capital Projects Funds", Definition="Capital Projects Funds financial account.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("95d1e648-8f0c-4832-83ac-5a07f42fe438"), Code="4", Description="Debt Service Funds", Definition="Debt Service Funds financial account.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("cbbc0b8d-bc9b-49cc-a899-5f0d26dea20f"), Code="5", Description="Permanent Funds", Definition="Permanent Funds financial account.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("e74a74a4-f2b2-4922-9112-06d54718ff53"), Code="6", Description="Enterprise Funds", Definition="Enterprise Funds financial account.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("a49ff6bc-385e-4707-931e-d2c935103846"), Code="7", Description="Internal Service Funds", Definition="Internal Service Funds financial account.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("f323982b-970a-41c3-b8bb-3222db763ef3"), Code="8", Description="Trust Funds", Definition="Trust Funds financial account.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("db8d5be9-c49c-41d9-a974-d7aab9506ae1"), Code="9", Description="Agency Funds", Definition="Agency Funds financial account.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefFinancialAccountFundClassification Pick List
         /// </summary>
        public static List<RefFinancialAccountFundClassification> RefFinancialAccountFundClassificationPickList = new List<RefFinancialAccountFundClassification>
        {
            new RefFinancialAccountFundClassification { Id=Guid.Parse("81689c0b-b858-4d82-9d37-be1fa90d2021"), Code="1", Description="General Fund", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("8f3d9fd3-42f0-4a43-afac-d1529fb424ef"), Code="2", Description="Special Revenue Funds", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("f07398eb-a88e-4727-aeda-34ede54c07dc"), Code="3", Description="Capital Projects Funds", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("95d1e648-8f0c-4832-83ac-5a07f42fe438"), Code="4", Description="Debt Service Funds", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("cbbc0b8d-bc9b-49cc-a899-5f0d26dea20f"), Code="5", Description="Permanent Funds", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("e74a74a4-f2b2-4922-9112-06d54718ff53"), Code="6", Description="Enterprise Funds", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("a49ff6bc-385e-4707-931e-d2c935103846"), Code="7", Description="Internal Service Funds", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("f323982b-970a-41c3-b8bb-3222db763ef3"), Code="8", Description="Trust Funds", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("db8d5be9-c49c-41d9-a974-d7aab9506ae1"), Code="9", Description="Agency Funds", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
