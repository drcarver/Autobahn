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
        /// The complete <see cref="RefFederalProgramFundingAllocationTypeModel"> List
         /// </summary>
        public static List<RefFederalProgramFundingAllocationTypeModel> RefFederalProgramFundingAllocationTypeList = new List<RefFederalProgramFundingAllocationTypeModel>
        {
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("096bd77c-3a78-4fb1-bf40-ebc24a52541c"), Code="RETAINED", Description="Retained by SEA for program administration, etc.", Definition="Retained by SEA for program administration, etc. is the type of federal program funding allocation or distribution made.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("5c0c24ff-f1a3-43d3-bffe-923aec23c273"), Code="TRANSFER", Description="Transferred to another state agency", Definition="Transferred to another state agency is the type of federal program funding allocation or distribution made.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("76ca5d2d-216e-4f99-8fb1-862582364816"), Code="DISTNONLEA", Description="Distributed to entities other  than LEAs", Definition="Distributed to entities other  than LEAs is the type of federal program funding allocation or distribution made.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("d3394249-9f1f-40e3-b295-edfe382d6f2e"), Code="UNALLOC", Description="Unallocated or returned funds", Definition="Unallocated or returned funds is the type of federal program funding allocation or distribution made.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefFederalProgramFundingAllocationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFederalProgramFundingAllocationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("096bd77c-3a78-4fb1-bf40-ebc24a52541c"), Description="Retained by SEA for program administration, etc.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("5c0c24ff-f1a3-43d3-bffe-923aec23c273"), Description="Transferred to another state agency", SortOrder=Convert.ToDecimal("2.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("76ca5d2d-216e-4f99-8fb1-862582364816"), Description="Distributed to entities other  than LEAs", SortOrder=Convert.ToDecimal("3.00") },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("d3394249-9f1f-40e3-b295-edfe382d6f2e"), Description="Unallocated or returned funds", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
