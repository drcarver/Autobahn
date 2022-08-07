//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefNaepAspectsOfReadingList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefNaepAspectsOfReading Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefNaepAspectsOfReadingModel"> List
         /// </summary>
        public static List<RefNaepAspectsOfReadingModel> RefNaepAspectsOfReadingList = new List<RefNaepAspectsOfReadingModel>
        {
            new RefNaepAspectsOfReading { Id=Guid.Parse("89c62dc1-99d1-45a8-8972-9f1ddbfc0442"), Code="DevelopingInterpretation", Description="Developing Interpretation", Definition="To develop an interpretation, the reader must extend initial impressions to arrive at a more complete understanding of what was read. This involves linking information across parts of a text as well as focusing on specific information.", SortOrder=Convert.ToDecimal("1.00") },
            new RefNaepAspectsOfReading { Id=Guid.Parse("df2fe117-9720-44bb-b648-458395b0443c"), Code="MakingReaderTextConnections", Description="Making reader/text connections", Definition="To make reader/text connections, the reader must link information in the text with knowledge and experience. This might include applying ideas in the text to the real world, and responses must be text based.", SortOrder=Convert.ToDecimal("2.00") },
            new RefNaepAspectsOfReading { Id=Guid.Parse("a12da856-c213-483c-bd92-71ac3287eec7"), Code="ExaminingContentAndStructure", Description="Examining content and structure", Definition="Examining text content and structure requires critically evaluating, comparing and contrasting, and understanding the effect of features such as irony, humor, and organization. Readers are required to stand apart from the text, consider it objectively, and evaluate its quality and appropriateness, using text content and structure.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefNaepAspectsOfReading Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefNaepAspectsOfReadingViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefNaepAspectsOfReading { Id=Guid.Parse("89c62dc1-99d1-45a8-8972-9f1ddbfc0442"), Description="Developing Interpretation", SortOrder=Convert.ToDecimal("1.00") },
            new RefNaepAspectsOfReading { Id=Guid.Parse("df2fe117-9720-44bb-b648-458395b0443c"), Description="Making reader/text connections", SortOrder=Convert.ToDecimal("2.00") },
            new RefNaepAspectsOfReading { Id=Guid.Parse("a12da856-c213-483c-bd92-71ac3287eec7"), Description="Examining content and structure", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
