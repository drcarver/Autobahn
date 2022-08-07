//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedUsageTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedUsageType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedUsageTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedUsageTypeModel> RefAssessmentNeedUsageTypeList = new List<RefAssessmentNeedUsageTypeModel>
        {
            new RefAssessmentNeedUsageType { Id=Guid.Parse("7518bed3-0b99-4ee2-bd7c-5d530273c2ff"), Code="Required", Description="Required", Definition="Required is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("62cdf2ce-0df5-47d8-8f1c-8ae534cb7e1d"), Code="Preferred", Description="Preferred", Definition="Preferred is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("45726fb6-d36b-4e79-8fee-d52a4bac0a91"), Code="OptionallyUse", Description="Optionally  use", Definition="Optionally  use is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("4e84e6bd-71ca-40e2-969f-02747709296d"), Code="Prohibited", Description="Prohibited", Definition="Prohibited is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedUsageType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedUsageTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedUsageType { Id=Guid.Parse("7518bed3-0b99-4ee2-bd7c-5d530273c2ff"), Description="Required", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("62cdf2ce-0df5-47d8-8f1c-8ae534cb7e1d"), Description="Preferred", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("45726fb6-d36b-4e79-8fee-d52a4bac0a91"), Description="Optionally  use", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("4e84e6bd-71ca-40e2-969f-02747709296d"), Description="Prohibited", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
