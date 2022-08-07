//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefFinancialAidVeteransBenefitTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefFinancialAidVeteransBenefitType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAidVeteransBenefitTypeModel"> List
         /// </summary>
        public static List<RefFinancialAidVeteransBenefitTypeModel> RefFinancialAidVeteransBenefitTypeList = new List<RefFinancialAidVeteransBenefitTypeModel>
        {
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("c2b75270-1cf8-4582-a100-4eb5039afa32"), Code="Post911GIBill", Description="Post-9/11 GI Bill", Definition="Post-9/11 GI Bill", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("680d134f-542a-4652-bf5e-f1921b2eadac"), Code="DODTuitionAssistance", Description="Department of Defense Tuition Assistance", Definition="Department of Defense Tuition Assistance", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefFinancialAidVeteransBenefitType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFinancialAidVeteransBenefitTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("c2b75270-1cf8-4582-a100-4eb5039afa32"), Description="Post-9/11 GI Bill", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("680d134f-542a-4652-bf5e-f1921b2eadac"), Description="Department of Defense Tuition Assistance", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
