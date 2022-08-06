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
        public static List<RefNaepMathComplexityLevel> RefNaepMathComplexityLevelList = new List<RefNaepMathComplexityLevel>
        {
            new RefNaepMathComplexityLevel { Id=Guid.Parse("5074cdbf-8f06-477c-bbbf-6212f0613e43"), Code="LowComplexity", Description="Low complexity", Definition="This category relies heavily on the recall and recognition of previously learned concepts and principles. Items typically specify what the student is to do, which is often to carry out some procedure that can be performed mechanically. It is not left to the student to come up with an original method or solution.", SortOrder=Convert.ToDecimal("1.00") },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("d15bf347-e455-4950-ba5e-bbf11f47a53f"), Code="ModerateComplexity", Description="Moderate complexity", Definition="Items in the moderate-complexity category involve more flexibility of thinking and choice among alternatives than do those in the low-complexity category. They require a response that goes beyond the habitual, is not specified, and ordinarily has more than a single step. The student is expected to decide what to do, using informal methods of reasoning and problem-solving strategies, and to bring together skill and knowledge from various domains.", SortOrder=Convert.ToDecimal("2.00") },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("e6459fc1-7c86-4e0f-aa7f-4891bf1e567d"), Code="HighComplexity", Description="High complexity", Definition="High-complexity items make heavy demands on students, who must engage in more abstract reasoning, planning, analysis, judgment, and creative thought. A satisfactory response to the item requires that the student think in an abstract and sophisticated way.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefNaepMathComplexityLevel Pick List
         /// </summary>
        public static List<RefNaepMathComplexityLevel> RefNaepMathComplexityLevelPickList = new List<RefNaepMathComplexityLevel>
        {
            new RefNaepMathComplexityLevel { Id=Guid.Parse("5074cdbf-8f06-477c-bbbf-6212f0613e43"), Code="LowComplexity", Description="Low complexity", SortOrder=Convert.ToDecimal("1.00") },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("d15bf347-e455-4950-ba5e-bbf11f47a53f"), Code="ModerateComplexity", Description="Moderate complexity", SortOrder=Convert.ToDecimal("2.00") },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("e6459fc1-7c86-4e0f-aa7f-4891bf1e567d"), Code="HighComplexity", Description="High complexity", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
