//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefReimbursementTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefReimbursementType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefReimbursementType"> List
         /// </summary>
        public static List<RefReimbursementType> RefReimbursementTypeList = new List<RefReimbursementType>
        {
            new RefReimbursementType { Id=Guid.Parse("b0a6b8d8-be4b-451d-bc7d-c03d63283611"), Code="FeeForService", Description="Fee for Service", Definition="Reimbursed via fee for service.", SortOrder=Convert.ToDecimal("1.00") },
            new RefReimbursementType { Id=Guid.Parse("15880dee-978c-47c3-90a4-efcc0cdcd5dd"), Code="CapitatedRate", Description="Capitated Rate", Definition="Reimbursed via capitated rate.", SortOrder=Convert.ToDecimal("3.00") },
            new RefReimbursementType { Id=Guid.Parse("235260eb-186e-4a9a-9781-b9ed93d20518"), Code="GrantContract", Description="Grant/contract", Definition="Reimbursed via grant/contract.", SortOrder=Convert.ToDecimal("5.00") },
            new RefReimbursementType { Id=Guid.Parse("9ea01a0c-385d-429d-9b8e-c5b575e309f2"), Code="Subsidy", Description="Subsidy", Definition="Reimbursed via subsidy.", SortOrder=Convert.ToDecimal("7.00") },
            new RefReimbursementType { Id=Guid.Parse("236d47e1-7081-4891-bff4-10f67374080a"), Code="Other", Description="Other", Definition="The reimbursement type is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefReimbursementType Pick List
         /// </summary>
        public static List<RefReimbursementType> RefReimbursementTypePickList = new List<RefReimbursementType>
        {
            new RefReimbursementType { Id=Guid.Parse("b0a6b8d8-be4b-451d-bc7d-c03d63283611"), Code="FeeForService", Description="Fee for Service", SortOrder=Convert.ToDecimal("1.00") },
            new RefReimbursementType { Id=Guid.Parse("15880dee-978c-47c3-90a4-efcc0cdcd5dd"), Code="CapitatedRate", Description="Capitated Rate", SortOrder=Convert.ToDecimal("3.00") },
            new RefReimbursementType { Id=Guid.Parse("235260eb-186e-4a9a-9781-b9ed93d20518"), Code="GrantContract", Description="Grant/contract", SortOrder=Convert.ToDecimal("5.00") },
            new RefReimbursementType { Id=Guid.Parse("9ea01a0c-385d-429d-9b8e-c5b575e309f2"), Code="Subsidy", Description="Subsidy", SortOrder=Convert.ToDecimal("7.00") },
            new RefReimbursementType { Id=Guid.Parse("236d47e1-7081-4891-bff4-10f67374080a"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
