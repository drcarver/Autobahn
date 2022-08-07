//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedMaskingTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedMaskingType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedMaskingTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedMaskingTypeModel> RefAssessmentNeedMaskingTypeList = new List<RefAssessmentNeedMaskingTypeModel>
        {
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("ef8831de-6d52-4c1b-8e87-2da19c652705"), Code="CustomMask", Description="Custom mask", Definition="Custom mask is specified as part of an Assessment Personal Needs Profile as the type of masks the user is able to create to cover portions of the question until needed.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("b93f8f9d-997e-4362-9b61-1a2c8cba0104"), Code="AnswerMask", Description="Answer mask", Definition="Answer mask is specified as part of an Assessment Personal Needs Profile as the type of masks the user is able to create to cover portions of the question until needed.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedMaskingType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedMaskingTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("ef8831de-6d52-4c1b-8e87-2da19c652705"), Description="Custom mask", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("b93f8f9d-997e-4362-9b61-1a2c8cba0104"), Description="Answer mask", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
