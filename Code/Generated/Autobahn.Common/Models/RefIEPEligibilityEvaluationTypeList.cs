//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIEPEligibilityEvaluationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIEPEligibilityEvaluationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIEPEligibilityEvaluationTypeModel"> List
         /// </summary>
        public static List<RefIEPEligibilityEvaluationTypeModel> RefIEPEligibilityEvaluationTypeList = new List<RefIEPEligibilityEvaluationTypeModel>
        {
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("e2c1c775-d2a4-412f-b8aa-a3c598b9a497"), Code="Initial", Description="Initial", Definition="Initial is the purpose within the IEP lifecycle for which the eligibility evaluation is conducted.", SortOrder=Convert.ToDecimal("") },
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("88ee33de-8794-4c7d-b9c4-88975e9581ad"), Code="Reevaluation", Description="Reevaluation", Definition="Reevaluation is the purpose within the IEP lifecycle for which the eligibility evaluation is conducted.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefIEPEligibilityEvaluationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIEPEligibilityEvaluationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("e2c1c775-d2a4-412f-b8aa-a3c598b9a497"), Description="Initial", SortOrder=Convert.ToDecimal("") },
            new RefIEPEligibilityEvaluationType { Id=Guid.Parse("88ee33de-8794-4c7d-b9c4-88975e9581ad"), Description="Reevaluation", SortOrder=Convert.ToDecimal("") },
       };
   }
}
