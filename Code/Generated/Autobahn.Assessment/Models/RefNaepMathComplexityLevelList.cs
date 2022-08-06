//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefNaepMathComplexityLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefNaepMathComplexityLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefNaepMathComplexityLevel"> List
         /// </summary>
        public static List<RefNaepMathComplexityLevel> RefNaepMathComplexityLevelList = new List<RefNaepMathComplexityLevel> =
        {
            new RefNaepMathComplexityLevel { Id=Guid.Parse("cbf177df-d290-44f8-9885-232d768cf8ba"), Code="This category relies heavily on the recall and recognition of previously learned concepts and principles. Items typically specify what the student is to do, which is often to carry out some procedure that can be performed mechanically. It is not left to the student to come up with an original method or solution.", Description="LowComplexity", Definition="", SortOrder=0 },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("893e2eb2-a1ba-4585-869b-f915bc53c621"), Code="Items in the moderate-complexity category involve more flexibility of thinking and choice among alternatives than do those in the low-complexity category. They require a response that goes beyond the habitual, is not specified, and ordinarily has more than a single step. The student is expected to decide what to do, using informal methods of reasoning and problem-solving strategies, and to bring together skill and knowledge from various domains.", Description="ModerateComplexity", Definition="", SortOrder=0 },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("4041acf5-9586-4b0b-bb50-1b886a938101"), Code="High-complexity items make heavy demands on students, who must engage in more abstract reasoning, planning, analysis, judgment, and creative thought. A satisfactory response to the item requires that the student think in an abstract and sophisticated way.", Description="HighComplexity", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefNaepMathComplexityLevel Pick List
         /// </summary>
        public static List<RefNaepMathComplexityLevel> RefNaepMathComplexityLevelPickList = new List<RefNaepMathComplexityLevel> =
        {
            new RefNaepMathComplexityLevel { Id=Guid.Parse("cbf177df-d290-44f8-9885-232d768cf8ba"), Code="This category relies heavily on the recall and recognition of previously learned concepts and principles. Items typically specify what the student is to do, which is often to carry out some procedure that can be performed mechanically. It is not left to the student to come up with an original method or solution.", SortOrder=0 },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("893e2eb2-a1ba-4585-869b-f915bc53c621"), Code="Items in the moderate-complexity category involve more flexibility of thinking and choice among alternatives than do those in the low-complexity category. They require a response that goes beyond the habitual, is not specified, and ordinarily has more than a single step. The student is expected to decide what to do, using informal methods of reasoning and problem-solving strategies, and to bring together skill and knowledge from various domains.", SortOrder=0 },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("4041acf5-9586-4b0b-bb50-1b886a938101"), Code="High-complexity items make heavy demands on students, who must engage in more abstract reasoning, planning, analysis, judgment, and creative thought. A satisfactory response to the item requires that the student think in an abstract and sophisticated way.", SortOrder=0 },
       };
   }
}
