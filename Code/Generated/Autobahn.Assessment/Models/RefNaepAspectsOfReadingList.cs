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
        /// The complete <see cref="RefNaepAspectsOfReading"> List
         /// </summary>
        public static List<RefNaepAspectsOfReading> RefNaepAspectsOfReadingList = new List<RefNaepAspectsOfReading>
        {
            new RefNaepAspectsOfReading { Id=Guid.Parse("fdaf3e64-09d7-40f2-b21a-ff81f5da97b4"), Code="DevelopingInterpretation", Description="Developing Interpretation", Definition="To develop an interpretation, the reader must extend initial impressions to arrive at a more complete understanding of what was read. This involves linking information across parts of a text as well as focusing on specific information.", SortOrder=Convert.ToDecimal("1.00") },
            new RefNaepAspectsOfReading { Id=Guid.Parse("7585f382-8389-41b8-bbb6-263f0896955e"), Code="MakingReaderTextConnections", Description="Making reader/text connections", Definition="To make reader/text connections, the reader must link information in the text with knowledge and experience. This might include applying ideas in the text to the real world, and responses must be text based.", SortOrder=Convert.ToDecimal("2.00") },
            new RefNaepAspectsOfReading { Id=Guid.Parse("1190fe05-8ee0-4e9b-ba2c-b58a3143a718"), Code="ExaminingContentAndStructure", Description="Examining content and structure", Definition="Examining text content and structure requires critically evaluating, comparing and contrasting, and understanding the effect of features such as irony, humor, and organization. Readers are required to stand apart from the text, consider it objectively, and evaluate its quality and appropriateness, using text content and structure.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefNaepAspectsOfReading Pick List
         /// </summary>
        public static List<RefNaepAspectsOfReading> RefNaepAspectsOfReadingPickList = new List<RefNaepAspectsOfReading>
        {
            new RefNaepAspectsOfReading { Id=Guid.Parse("fdaf3e64-09d7-40f2-b21a-ff81f5da97b4"), Code="DevelopingInterpretation", Description="Developing Interpretation", SortOrder=Convert.ToDecimal("1.00") },
            new RefNaepAspectsOfReading { Id=Guid.Parse("7585f382-8389-41b8-bbb6-263f0896955e"), Code="MakingReaderTextConnections", Description="Making reader/text connections", SortOrder=Convert.ToDecimal("2.00") },
            new RefNaepAspectsOfReading { Id=Guid.Parse("1190fe05-8ee0-4e9b-ba2c-b58a3143a718"), Code="ExaminingContentAndStructure", Description="Examining content and structure", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
