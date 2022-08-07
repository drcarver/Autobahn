//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAssessmentNeedBrailleStatusCellTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedBrailleStatusCellType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedBrailleStatusCellTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedBrailleStatusCellTypeModel> RefAssessmentNeedBrailleStatusCellTypeList = new List<RefAssessmentNeedBrailleStatusCellTypeModel>
        {
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("775449c8-2290-4438-b06b-e0ffdfcaa166"), Code="Off", Description="Off", Definition="Defines as part of an Assessment Personal Needs Profile the preferred presence of a Braille display status cell set to Off.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("4ce49cdd-f26b-464a-baac-ae447d2f67e1"), Code="Left", Description="Left", Definition="Defines as part of an Assessment Personal Needs Profile the preferred location of a Braille display status cell set to Left.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("a388de48-c779-43f8-9ebf-f1a073c16c45"), Code="Right", Description="Right", Definition="Defines as part of an Assessment Personal Needs Profile the preferred location of a Braille display status cell Right.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedBrailleStatusCellType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedBrailleStatusCellTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("775449c8-2290-4438-b06b-e0ffdfcaa166"), Description="Off", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("4ce49cdd-f26b-464a-baac-ae447d2f67e1"), Description="Left", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("a388de48-c779-43f8-9ebf-f1a073c16c45"), Description="Right", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
