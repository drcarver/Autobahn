//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefWageVerificationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefWageVerification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefWageVerificationModel"> List
         /// </summary>
        public static List<RefWageVerificationModel> RefWageVerificationList = new List<RefWageVerificationModel>
        {
            new RefWageVerification { Id=Guid.Parse("0b9317df-3c58-4319-960e-c9a9fee060bf"), Code="01", Description="Verified", Definition="The wage information has been verified.", SortOrder=Convert.ToDecimal("1.00") },
            new RefWageVerification { Id=Guid.Parse("018b0f5f-1f3a-4f62-a006-5ae91159dc64"), Code="02", Description="Not verified", Definition="The wage information has NOT been verified.", SortOrder=Convert.ToDecimal("2.00") },
            new RefWageVerification { Id=Guid.Parse("2b38612e-a1c4-410e-b92f-9b71a14b8a1b"), Code="03", Description="Wage data not present", Definition="Wage data not present.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefWageVerification Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefWageVerificationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefWageVerification { Id=Guid.Parse("0b9317df-3c58-4319-960e-c9a9fee060bf"), Description="Verified", SortOrder=Convert.ToDecimal("1.00") },
            new RefWageVerification { Id=Guid.Parse("018b0f5f-1f3a-4f62-a006-5ae91159dc64"), Description="Not verified", SortOrder=Convert.ToDecimal("2.00") },
            new RefWageVerification { Id=Guid.Parse("2b38612e-a1c4-410e-b92f-9b71a14b8a1b"), Description="Wage data not present", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
