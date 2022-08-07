//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedBrailleMarkTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedBrailleMarkType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedBrailleMarkTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedBrailleMarkTypeModel> RefAssessmentNeedBrailleMarkTypeList = new List<RefAssessmentNeedBrailleMarkTypeModel>
        {
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("06f3d243-03f7-4ca6-a685-ae2192e803ec"), Code="Highlight", Description="Highlight", Definition="Highlight is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("420869c4-6d67-4cc3-9e9d-43ded10a9409"), Code="1.00", Description="", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("8e5045cc-f73c-4a45-803b-51fbae8aaf31"), Code="Bold", Description="Bold", Definition="Bold is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("75e92473-131b-4372-9ef9-4c592f030593"), Code="Underline", Description="Underline", Definition="Underline is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("14637c1d-e03a-460e-864d-58008890454c"), Code="Italic", Description="Italic", Definition="Italic is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("ade9ab41-3f8e-4bb6-95a4-7b8583b7ae9b"), Code="Strikeout", Description="Strikeout", Definition="Strikeout is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("e4ec7555-d572-49af-b55b-e508420a286b"), Code="Color", Description="Color", Definition="Color is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedBrailleMarkType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedBrailleMarkTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("06f3d243-03f7-4ca6-a685-ae2192e803ec"), Description="Highlight", SortOrder=Convert.ToDecimal("") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("420869c4-6d67-4cc3-9e9d-43ded10a9409"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("8e5045cc-f73c-4a45-803b-51fbae8aaf31"), Description="Bold", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("75e92473-131b-4372-9ef9-4c592f030593"), Description="Underline", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("14637c1d-e03a-460e-864d-58008890454c"), Description="Italic", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("ade9ab41-3f8e-4bb6-95a4-7b8583b7ae9b"), Description="Strikeout", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("e4ec7555-d572-49af-b55b-e508420a286b"), Description="Color", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
