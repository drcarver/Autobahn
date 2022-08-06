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
        public static List<RefAssessmentNeedBrailleGradeType> RefAssessmentNeedBrailleGradeTypeList = new List<RefAssessmentNeedBrailleGradeType>
        {
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("d8d49146-991d-4595-934a-304807a51867"), Code="Contracted", Description="Contracted", Definition="Contracted is defined as part of an Assessment Personal Needs Profile to be the grade of Braille to use when using a Braille display.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("756bb082-a005-4e12-bd6e-d191ea72358b"), Code="Uncontracted", Description="Uncontracted", Definition="Uncontracted is defined as part of an Assessment Personal Needs Profile to be the grade of Braille to use when using a Braille display.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedBrailleGradeType Pick List
         /// </summary>
        public static List<RefAssessmentNeedBrailleGradeType> RefAssessmentNeedBrailleGradeTypePickList = new List<RefAssessmentNeedBrailleGradeType>
        {
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("d8d49146-991d-4595-934a-304807a51867"), Code="Contracted", Description="Contracted", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedBrailleGradeType { Id=Guid.Parse("756bb082-a005-4e12-bd6e-d191ea72358b"), Code="Uncontracted", Description="Uncontracted", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
