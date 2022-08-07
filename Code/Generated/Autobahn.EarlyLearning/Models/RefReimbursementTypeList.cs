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
        /// The complete <see cref="RefReimbursementTypeModel"> List
         /// </summary>
        public static List<RefReimbursementTypeModel> RefReimbursementTypeList = new List<RefReimbursementTypeModel>
        {
            new RefReimbursementType { Id=Guid.Parse("f2e7f943-5deb-45cc-b3b0-c4bb3325f576"), Code="FeeForService", Description="Fee for Service", Definition="Reimbursed via fee for service.", SortOrder=Convert.ToDecimal("1.00") },
            new RefReimbursementType { Id=Guid.Parse("ae6cc981-e275-4390-a2d6-3c0490c575d1"), Code="CapitatedRate", Description="Capitated Rate", Definition="Reimbursed via capitated rate.", SortOrder=Convert.ToDecimal("3.00") },
            new RefReimbursementType { Id=Guid.Parse("3c1692ee-2866-4083-b1de-21c10b6ce7ad"), Code="GrantContract", Description="Grant/contract", Definition="Reimbursed via grant/contract.", SortOrder=Convert.ToDecimal("5.00") },
            new RefReimbursementType { Id=Guid.Parse("49c31675-45d6-4e57-b24f-096aa0eeb9bc"), Code="Subsidy", Description="Subsidy", Definition="Reimbursed via subsidy.", SortOrder=Convert.ToDecimal("7.00") },
            new RefReimbursementType { Id=Guid.Parse("5f47cae9-839a-4ccd-b8dc-5785a3bd92b0"), Code="Other", Description="Other", Definition="The reimbursement type is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefReimbursementType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefReimbursementTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefReimbursementType { Id=Guid.Parse("f2e7f943-5deb-45cc-b3b0-c4bb3325f576"), Description="Fee for Service", SortOrder=Convert.ToDecimal("1.00") },
            new RefReimbursementType { Id=Guid.Parse("ae6cc981-e275-4390-a2d6-3c0490c575d1"), Description="Capitated Rate", SortOrder=Convert.ToDecimal("3.00") },
            new RefReimbursementType { Id=Guid.Parse("3c1692ee-2866-4083-b1de-21c10b6ce7ad"), Description="Grant/contract", SortOrder=Convert.ToDecimal("5.00") },
            new RefReimbursementType { Id=Guid.Parse("49c31675-45d6-4e57-b24f-096aa0eeb9bc"), Description="Subsidy", SortOrder=Convert.ToDecimal("7.00") },
            new RefReimbursementType { Id=Guid.Parse("5f47cae9-839a-4ccd-b8dc-5785a3bd92b0"), Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
