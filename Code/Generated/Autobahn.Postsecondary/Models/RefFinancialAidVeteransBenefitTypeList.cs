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
        /// The complete <see cref="RefFinancialAidVeteransBenefitType"> List
         /// </summary>
        public static List<RefFinancialAidVeteransBenefitType> RefFinancialAidVeteransBenefitTypeList = new List<RefFinancialAidVeteransBenefitType>
        {
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("c999cfb0-766e-4013-8ab6-89c88a90bb76"), Code="Post911GIBill", Description="Post-9/11 GI Bill", Definition="Post-9/11 GI Bill", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("a6fb0b1a-f0c5-4868-a34c-1a963cc5d9c3"), Code="DODTuitionAssistance", Description="Department of Defense Tuition Assistance", Definition="Department of Defense Tuition Assistance", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefFinancialAidVeteransBenefitType Pick List
         /// </summary>
        public static List<RefFinancialAidVeteransBenefitType> RefFinancialAidVeteransBenefitTypePickList = new List<RefFinancialAidVeteransBenefitType>
        {
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("c999cfb0-766e-4013-8ab6-89c88a90bb76"), Code="Post911GIBill", Description="Post-9/11 GI Bill", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("a6fb0b1a-f0c5-4868-a34c-1a963cc5d9c3"), Code="DODTuitionAssistance", Description="Department of Defense Tuition Assistance", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
