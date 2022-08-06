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
        /// The complete <see cref="RefAssessmentNeedBrailleGradeType"> List
         /// </summary>
        public static List<RefAssessmentNeedBrailleGradeType> RefAssessmentNeedBrailleGradeTypeList = new List<RefAssessmentNeedBrailleGradeType> =
        {
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("7e572bb3-4d85-4e92-b524-012925ea163c"), Code="Contracted is defined as part of an Assessment Personal Needs Profile to be the grade of Braille to use when using a Braille display.", Description="Contracted", Definition="", SortOrder=0 },
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("9017e770-97ec-43ef-be33-ad7262277729"), Code="Uncontracted is defined as part of an Assessment Personal Needs Profile to be the grade of Braille to use when using a Braille display.", Description="Uncontracted", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedBrailleGradeType Pick List
         /// </summary>
        public static List<RefAssessmentNeedBrailleGradeType> RefAssessmentNeedBrailleGradeTypePickList = new List<RefAssessmentNeedBrailleGradeType> =
        {
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("7e572bb3-4d85-4e92-b524-012925ea163c"), Code="Contracted is defined as part of an Assessment Personal Needs Profile to be the grade of Braille to use when using a Braille display.", SortOrder=0 },
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("9017e770-97ec-43ef-be33-ad7262277729"), Code="Uncontracted is defined as part of an Assessment Personal Needs Profile to be the grade of Braille to use when using a Braille display.", SortOrder=0 },
       };
   }
}
