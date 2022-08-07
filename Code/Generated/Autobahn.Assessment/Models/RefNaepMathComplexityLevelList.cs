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
        /// The complete <see cref="RefNaepMathComplexityLevelModel"> List
         /// </summary>
        public static List<RefNaepMathComplexityLevelModel> RefNaepMathComplexityLevelList = new List<RefNaepMathComplexityLevelModel>
        {
            new RefNaepMathComplexityLevel { Id=Guid.Parse("4f452720-394d-41cb-8bd3-0ab92c5b89cd"), Code="LowComplexity", Description="Low complexity", Definition="This category relies heavily on the recall and recognition of previously learned concepts and principles. Items typically specify what the student is to do, which is often to carry out some procedure that can be performed mechanically. It is not left to the student to come up with an original method or solution.", SortOrder=Convert.ToDecimal("1.00") },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("eb6b4ed7-a09b-4e03-85ac-48d06d32f4ce"), Code="ModerateComplexity", Description="Moderate complexity", Definition="Items in the moderate-complexity category involve more flexibility of thinking and choice among alternatives than do those in the low-complexity category. They require a response that goes beyond the habitual, is not specified, and ordinarily has more than a single step. The student is expected to decide what to do, using informal methods of reasoning and problem-solving strategies, and to bring together skill and knowledge from various domains.", SortOrder=Convert.ToDecimal("2.00") },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("dc905c70-7a98-4770-9b6a-a3a878a9621e"), Code="HighComplexity", Description="High complexity", Definition="High-complexity items make heavy demands on students, who must engage in more abstract reasoning, planning, analysis, judgment, and creative thought. A satisfactory response to the item requires that the student think in an abstract and sophisticated way.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefNaepMathComplexityLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefNaepMathComplexityLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefNaepMathComplexityLevel { Id=Guid.Parse("4f452720-394d-41cb-8bd3-0ab92c5b89cd"), Description="Low complexity", SortOrder=Convert.ToDecimal("1.00") },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("eb6b4ed7-a09b-4e03-85ac-48d06d32f4ce"), Description="Moderate complexity", SortOrder=Convert.ToDecimal("2.00") },
            new RefNaepMathComplexityLevel { Id=Guid.Parse("dc905c70-7a98-4770-9b6a-a3a878a9621e"), Description="High complexity", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
