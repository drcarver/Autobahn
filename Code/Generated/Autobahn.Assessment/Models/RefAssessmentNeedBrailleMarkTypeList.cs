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
        /// The complete <see cref="RefAssessmentNeedBrailleMarkType"> List
         /// </summary>
        public static List<RefAssessmentNeedBrailleMarkType> RefAssessmentNeedBrailleMarkTypeList = new List<RefAssessmentNeedBrailleMarkType>
        {
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("20c203f8-a26a-4671-9ec4-ffd7657298fd"), Code="Highlight", Description="Highlight", Definition="Highlight is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("9152afbd-0605-4538-9650-a6d03d8d8cb6"), Code="1.00", Description="", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("94e40d00-537d-4a08-a002-9544d8a6849d"), Code="Bold", Description="Bold", Definition="Bold is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("140603c7-347c-405c-a374-03e9b1309623"), Code="Underline", Description="Underline", Definition="Underline is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("7bd7c947-f03e-4b5e-8fa1-cd42c8153b33"), Code="Italic", Description="Italic", Definition="Italic is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("7161f877-bf30-4765-bf80-b8edb032e1bd"), Code="Strikeout", Description="Strikeout", Definition="Strikeout is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("0aacccce-fbe4-4cf3-9295-cf6be4634a7a"), Code="Color", Description="Color", Definition="Color is defined as part of an Assessment Personal Needs Profile as a textual property to mark when using a Braille display.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedBrailleMarkType Pick List
         /// </summary>
        public static List<RefAssessmentNeedBrailleMarkType> RefAssessmentNeedBrailleMarkTypePickList = new List<RefAssessmentNeedBrailleMarkType>
        {
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("20c203f8-a26a-4671-9ec4-ffd7657298fd"), Code="Highlight", Description="Highlight", SortOrder=Convert.ToDecimal("") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("9152afbd-0605-4538-9650-a6d03d8d8cb6"), Code="1.00", Description="", SortOrder=Convert.ToDecimal("") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("94e40d00-537d-4a08-a002-9544d8a6849d"), Code="Bold", Description="Bold", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("140603c7-347c-405c-a374-03e9b1309623"), Code="Underline", Description="Underline", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("7bd7c947-f03e-4b5e-8fa1-cd42c8153b33"), Code="Italic", Description="Italic", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("7161f877-bf30-4765-bf80-b8edb032e1bd"), Code="Strikeout", Description="Strikeout", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentNeedBrailleMarkType { Id=Guid.Parse("0aacccce-fbe4-4cf3-9295-cf6be4634a7a"), Code="Color", Description="Color", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
