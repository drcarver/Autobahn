//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityApprovedPurposeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityApprovedPurpose Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityApprovedPurposeModel"> List
         /// </summary>
        public static List<RefPDActivityApprovedPurposeModel> RefPDActivityApprovedPurposeList = new List<RefPDActivityApprovedPurposeModel>
        {
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("64e4ee2e-8a50-4b8c-8ae3-38ee33c987be"), Code="QRIS", Description="Quality Rating and Improvement System", Definition="Quality Rating and Improvement System is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("52087cde-3ccf-4c46-b0ae-ad2e27659394"), Code="Licensing", Description="Licensing", Definition="Licensing is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("7afa1bdd-6297-434e-bf9b-e44f65665089"), Code="StateStandard", Description="State standard", Definition="State standard is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("402252a7-2b9d-428a-9379-8ff228ea5c5a"), Code="Other", Description="Other", Definition="The purposes for which the professional development activity was approved is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefPDActivityApprovedPurpose Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPDActivityApprovedPurposeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("64e4ee2e-8a50-4b8c-8ae3-38ee33c987be"), Description="Quality Rating and Improvement System", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("52087cde-3ccf-4c46-b0ae-ad2e27659394"), Description="Licensing", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("7afa1bdd-6297-434e-bf9b-e44f65665089"), Description="State standard", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityApprovedPurpose { Id=Guid.Parse("402252a7-2b9d-428a-9379-8ff228ea5c5a"), Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
