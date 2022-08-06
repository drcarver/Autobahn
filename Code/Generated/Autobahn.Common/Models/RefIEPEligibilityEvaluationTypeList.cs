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
        public static List<RefIEPEligibilityEvaluationType> RefIEPEligibilityEvaluationTypeList = new List<RefIEPEligibilityEvaluationType> =
        {
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("7972069d-641c-4d39-b96c-ab1bd67d6351"), Code="Initial is the purpose within the IEP lifecycle for which the eligibility evaluation is conducted.", Description="Initial", Definition="", SortOrder=0 },
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("2132644b-3ab4-4aca-bebc-d0b22a6a8775"), Code="Reevaluation is the purpose within the IEP lifecycle for which the eligibility evaluation is conducted.", Description="Reevaluation", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIEPEligibilityEvaluationType Pick List
         /// </summary>
        public static List<RefIEPEligibilityEvaluationType> RefIEPEligibilityEvaluationTypePickList = new List<RefIEPEligibilityEvaluationType> =
        {
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("7972069d-641c-4d39-b96c-ab1bd67d6351"), Code="Initial is the purpose within the IEP lifecycle for which the eligibility evaluation is conducted.", SortOrder=0 },
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("2132644b-3ab4-4aca-bebc-d0b22a6a8775"), Code="Reevaluation is the purpose within the IEP lifecycle for which the eligibility evaluation is conducted.", SortOrder=0 },
       };
   }
}
