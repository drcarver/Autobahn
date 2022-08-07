//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedBrailleGradeTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedBrailleGradeType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedBrailleGradeTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedBrailleGradeTypeModel> RefAssessmentNeedBrailleGradeTypeList = new List<RefAssessmentNeedBrailleGradeTypeModel>
        {
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("0d67df8c-2fd0-4dc5-be8b-7fac84f2460e"), Code="Contracted", Description="Contracted", Definition="Contracted is defined as part of an Assessment Personal Needs Profile to be the grade of Braille to use when using a Braille display.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("06258a6a-4670-4d80-9d6c-c8b9c1b7901d"), Code="Uncontracted", Description="Uncontracted", Definition="Uncontracted is defined as part of an Assessment Personal Needs Profile to be the grade of Braille to use when using a Braille display.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedBrailleGradeType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedBrailleGradeTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("0d67df8c-2fd0-4dc5-be8b-7fac84f2460e"), Description="Contracted", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("06258a6a-4670-4d80-9d6c-c8b9c1b7901d"), Description="Uncontracted", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
