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
        public static List<RefFederalProgramFundingAllocationType> RefFederalProgramFundingAllocationTypeList = new List<RefFederalProgramFundingAllocationType> =
        {
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("8e719a87-f7b9-4809-80bf-d5210186cfb2"), Code="Retained by SEA for program administration, etc. is the type of federal program funding allocation or distribution made.", Description="RETAINED", Definition="", SortOrder=0 },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("a5cde889-1e8d-40cb-8447-5efe0553a500"), Code="Transferred to another state agency is the type of federal program funding allocation or distribution made.", Description="TRANSFER", Definition="", SortOrder=0 },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("e92ffc51-2df6-4c74-961c-33a7403f3960"), Code="Distributed to entities other  than LEAs is the type of federal program funding allocation or distribution made.", Description="DISTNONLEA", Definition="", SortOrder=0 },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("4c3d667f-4312-424c-82be-636bdcc3381a"), Code="Unallocated or returned funds is the type of federal program funding allocation or distribution made.", Description="UNALLOC", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFederalProgramFundingAllocationType Pick List
         /// </summary>
        public static List<RefFederalProgramFundingAllocationType> RefFederalProgramFundingAllocationTypePickList = new List<RefFederalProgramFundingAllocationType> =
        {
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("8e719a87-f7b9-4809-80bf-d5210186cfb2"), Code="Retained by SEA for program administration, etc. is the type of federal program funding allocation or distribution made.", SortOrder=0 },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("a5cde889-1e8d-40cb-8447-5efe0553a500"), Code="Transferred to another state agency is the type of federal program funding allocation or distribution made.", SortOrder=0 },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("e92ffc51-2df6-4c74-961c-33a7403f3960"), Code="Distributed to entities other  than LEAs is the type of federal program funding allocation or distribution made.", SortOrder=0 },
            new RefFederalProgramFundingAllocationType { Id=Guid.Parse("4c3d667f-4312-424c-82be-636bdcc3381a"), Code="Unallocated or returned funds is the type of federal program funding allocation or distribution made.", SortOrder=0 },
       };
   }
}
