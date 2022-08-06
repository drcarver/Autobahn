//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefFederalProgramFundingAllocationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefFederalProgramFundingAllocationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFederalProgramFundingAllocationType"> List
         /// </summary>
        public static List<RefFederalProgramFundingAllocationType> RefFederalProgramFundingAllocationTypeList = new List<RefFederalProgramFundingAllocationType>
        {
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("68b1eac0-cb17-413c-9861-48c7f7ff920b"), Code="RETAINED", Description="Retained by SEA for program administration, etc.", Definition="Retained by SEA for program administration, etc. is the type of federal program funding allocation or distribution made.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("5c9c9045-a1da-471a-b9a6-e240f258d187"), Code="TRANSFER", Description="Transferred to another state agency", Definition="Transferred to another state agency is the type of federal program funding allocation or distribution made.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("9b4d675c-ae9d-4654-9b44-789582b803d9"), Code="DISTNONLEA", Description="Distributed to entities other  than LEAs", Definition="Distributed to entities other  than LEAs is the type of federal program funding allocation or distribution made.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("b11febc6-6c10-4556-a418-2f88560ea01f"), Code="UNALLOC", Description="Unallocated or returned funds", Definition="Unallocated or returned funds is the type of federal program funding allocation or distribution made.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefFederalProgramFundingAllocationType Pick List
         /// </summary>
        public static List<RefFederalProgramFundingAllocationType> RefFederalProgramFundingAllocationTypePickList = new List<RefFederalProgramFundingAllocationType>
        {
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("68b1eac0-cb17-413c-9861-48c7f7ff920b"), Code="RETAINED", Description="Retained by SEA for program administration, etc.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("5c9c9045-a1da-471a-b9a6-e240f258d187"), Code="TRANSFER", Description="Transferred to another state agency", SortOrder=Convert.ToDecimal("2.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("9b4d675c-ae9d-4654-9b44-789582b803d9"), Code="DISTNONLEA", Description="Distributed to entities other  than LEAs", SortOrder=Convert.ToDecimal("3.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("b11febc6-6c10-4556-a418-2f88560ea01f"), Code="UNALLOC", Description="Unallocated or returned funds", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
