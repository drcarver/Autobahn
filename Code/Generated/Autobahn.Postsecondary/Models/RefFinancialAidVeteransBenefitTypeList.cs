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
        public static List<RefFinancialAidVeteransBenefitType> RefFinancialAidVeteransBenefitTypeList = new List<RefFinancialAidVeteransBenefitType> =
        {
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("df81f22f-d99a-48ec-8787-658e3e09c73b"), Code="Post-9/11 GI Bill", Description="Post911GIBill", Definition="", SortOrder=0 },
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("1f7803fb-4967-40df-ba65-d3e4aa9c3dd7"), Code="Department of Defense Tuition Assistance", Description="DODTuitionAssistance", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFinancialAidVeteransBenefitType Pick List
         /// </summary>
        public static List<RefFinancialAidVeteransBenefitType> RefFinancialAidVeteransBenefitTypePickList = new List<RefFinancialAidVeteransBenefitType> =
        {
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("df81f22f-d99a-48ec-8787-658e3e09c73b"), Code="Post-9/11 GI Bill", SortOrder=0 },
            new RefFinancialAidVeteransBenefitType { Id=Guid.Parse("1f7803fb-4967-40df-ba65-d3e4aa9c3dd7"), Code="Department of Defense Tuition Assistance", SortOrder=0 },
       };
   }
}
