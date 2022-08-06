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
        public static List<RefFinancialAccountFundClassification> RefFinancialAccountFundClassificationList = new List<RefFinancialAccountFundClassification> =
        {
            new RefFinancialAccountFundClassification { Id=Guid.Parse("8d08141b-7825-4b85-ad16-cbb8eb42d8d7"), Code="General Fund financial account.", Description="1", Definition="", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("cf5cb139-c979-457c-8d53-95c60a889cb3"), Code="Special Revenue Funds financial account.", Description="2", Definition="", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("8063b91f-2bb1-42cc-a7c8-0733554ee913"), Code="Capital Projects Funds financial account.", Description="3", Definition="", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("95c73744-362f-42ae-b45c-973c037f8bd2"), Code="Debt Service Funds financial account.", Description="4", Definition="", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("35f32866-7263-43ce-ba88-6dc78e859412"), Code="Permanent Funds financial account.", Description="5", Definition="", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("6692b44e-c027-48d8-af75-0acbd14b1a61"), Code="Enterprise Funds financial account.", Description="6", Definition="", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("3fae314b-bfb4-466a-a9e0-b2825ca7bdad"), Code="Internal Service Funds financial account.", Description="7", Definition="", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("5be8d215-2030-4cbb-80ad-e1e652426628"), Code="Trust Funds financial account.", Description="8", Definition="", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("adcba646-9fad-479d-9217-c9820d9c3027"), Code="Agency Funds financial account.", Description="9", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFinancialAccountFundClassification Pick List
         /// </summary>
        public static List<RefFinancialAccountFundClassification> RefFinancialAccountFundClassificationPickList = new List<RefFinancialAccountFundClassification> =
        {
            new RefFinancialAccountFundClassification { Id=Guid.Parse("8d08141b-7825-4b85-ad16-cbb8eb42d8d7"), Code="General Fund financial account.", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("cf5cb139-c979-457c-8d53-95c60a889cb3"), Code="Special Revenue Funds financial account.", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("8063b91f-2bb1-42cc-a7c8-0733554ee913"), Code="Capital Projects Funds financial account.", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("95c73744-362f-42ae-b45c-973c037f8bd2"), Code="Debt Service Funds financial account.", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("35f32866-7263-43ce-ba88-6dc78e859412"), Code="Permanent Funds financial account.", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("6692b44e-c027-48d8-af75-0acbd14b1a61"), Code="Enterprise Funds financial account.", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("3fae314b-bfb4-466a-a9e0-b2825ca7bdad"), Code="Internal Service Funds financial account.", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("5be8d215-2030-4cbb-80ad-e1e652426628"), Code="Trust Funds financial account.", SortOrder=0 },
            new RefFinancialAccountFundClassification { Id=Guid.Parse("adcba646-9fad-479d-9217-c9820d9c3027"), Code="Agency Funds financial account.", SortOrder=0 },
       };
   }
}
