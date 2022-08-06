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
        public static List<RefReimbursementType> RefReimbursementTypeList = new List<RefReimbursementType> =
        {
            new RefReimbursementType { Id=Guid.Parse("0548b4ae-5e98-4fd4-a261-a9ede52e467a"), Code="Reimbursed via fee for service.", Description="FeeForService", Definition="", SortOrder=0 },
            new RefReimbursementType { Id=Guid.Parse("c511aa29-6794-4a33-aad1-a63752ef7c87"), Code="Reimbursed via capitated rate.", Description="CapitatedRate", Definition="", SortOrder=0 },
            new RefReimbursementType { Id=Guid.Parse("34a54bf7-cbdb-45f5-9731-20376a74c631"), Code="Reimbursed via grant/contract.", Description="GrantContract", Definition="", SortOrder=0 },
            new RefReimbursementType { Id=Guid.Parse("d3028204-63f8-47ee-b34b-ff6e0c48d02e"), Code="Reimbursed via subsidy.", Description="Subsidy", Definition="", SortOrder=0 },
            new RefReimbursementType { Id=Guid.Parse("37102710-5e36-440f-bb1a-af4d12cb5639"), Code="The reimbursement type is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefReimbursementType Pick List
         /// </summary>
        public static List<RefReimbursementType> RefReimbursementTypePickList = new List<RefReimbursementType> =
        {
            new RefReimbursementType { Id=Guid.Parse("0548b4ae-5e98-4fd4-a261-a9ede52e467a"), Code="Reimbursed via fee for service.", SortOrder=0 },
            new RefReimbursementType { Id=Guid.Parse("c511aa29-6794-4a33-aad1-a63752ef7c87"), Code="Reimbursed via capitated rate.", SortOrder=0 },
            new RefReimbursementType { Id=Guid.Parse("34a54bf7-cbdb-45f5-9731-20376a74c631"), Code="Reimbursed via grant/contract.", SortOrder=0 },
            new RefReimbursementType { Id=Guid.Parse("d3028204-63f8-47ee-b34b-ff6e0c48d02e"), Code="Reimbursed via subsidy.", SortOrder=0 },
            new RefReimbursementType { Id=Guid.Parse("37102710-5e36-440f-bb1a-af4d12cb5639"), Code="The reimbursement type is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
