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
        public static List<RefNaepAspectsOfReading> RefNaepAspectsOfReadingList = new List<RefNaepAspectsOfReading> =
        {
            new RefNaepAspectsOfReading { Id=Guid.Parse("773d5333-8559-4d4f-94a9-82ce6daecf31"), Code="To develop an interpretation, the reader must extend initial impressions to arrive at a more complete understanding of what was read. This involves linking information across parts of a text as well as focusing on specific information.", Description="DevelopingInterpretation", Definition="", SortOrder=0 },
            new RefNaepAspectsOfReading { Id=Guid.Parse("44ab868f-b941-40e6-90da-13f8bb656b15"), Code="To make reader/text connections, the reader must link information in the text with knowledge and experience. This might include applying ideas in the text to the real world, and responses must be text based.", Description="MakingReaderTextConnections", Definition="", SortOrder=0 },
            new RefNaepAspectsOfReading { Id=Guid.Parse("31fab607-0ff7-4d08-9324-f26621598c57"), Code="Examining text content and structure requires critically evaluating, comparing and contrasting, and understanding the effect of features such as irony, humor, and organization. Readers are required to stand apart from the text, consider it objectively, and evaluate its quality and appropriateness, using text content and structure.", Description="ExaminingContentAndStructure", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefNaepAspectsOfReading Pick List
         /// </summary>
        public static List<RefNaepAspectsOfReading> RefNaepAspectsOfReadingPickList = new List<RefNaepAspectsOfReading> =
        {
            new RefNaepAspectsOfReading { Id=Guid.Parse("773d5333-8559-4d4f-94a9-82ce6daecf31"), Code="To develop an interpretation, the reader must extend initial impressions to arrive at a more complete understanding of what was read. This involves linking information across parts of a text as well as focusing on specific information.", SortOrder=0 },
            new RefNaepAspectsOfReading { Id=Guid.Parse("44ab868f-b941-40e6-90da-13f8bb656b15"), Code="To make reader/text connections, the reader must link information in the text with knowledge and experience. This might include applying ideas in the text to the real world, and responses must be text based.", SortOrder=0 },
            new RefNaepAspectsOfReading { Id=Guid.Parse("31fab607-0ff7-4d08-9324-f26621598c57"), Code="Examining text content and structure requires critically evaluating, comparing and contrasting, and understanding the effect of features such as irony, humor, and organization. Readers are required to stand apart from the text, consider it objectively, and evaluate its quality and appropriateness, using text content and structure.", SortOrder=0 },
       };
   }
}
