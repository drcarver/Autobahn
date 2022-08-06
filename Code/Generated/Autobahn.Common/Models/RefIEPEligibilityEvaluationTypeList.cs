//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIEPEligibilityEvaluationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIEPEligibilityEvaluationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIEPEligibilityEvaluationType"> List
         /// </summary>
        public static List<RefIEPEligibilityEvaluationType> RefIEPEligibilityEvaluationTypeList = new List<RefIEPEligibilityEvaluationType>
        {
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("17bfdb55-6ff9-45ce-bb7e-03952d9fcd0c"), Code="Initial", Description="Initial", Definition="Initial is the purpose within the IEP lifecycle for which the eligibility evaluation is conducted.", SortOrder=Convert.ToDecimal("") },
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("f2945039-0489-4af2-b9f4-6c4b78952006"), Code="Reevaluation", Description="Reevaluation", Definition="Reevaluation is the purpose within the IEP lifecycle for which the eligibility evaluation is conducted.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefIEPEligibilityEvaluationType Pick List
         /// </summary>
        public static List<RefIEPEligibilityEvaluationType> RefIEPEligibilityEvaluationTypePickList = new List<RefIEPEligibilityEvaluationType>
        {
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("17bfdb55-6ff9-45ce-bb7e-03952d9fcd0c"), Code="Initial", Description="Initial", SortOrder=Convert.ToDecimal("") },
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("f2945039-0489-4af2-b9f4-6c4b78952006"), Code="Reevaluation", Description="Reevaluation", SortOrder=Convert.ToDecimal("") },
       };
   }
}
