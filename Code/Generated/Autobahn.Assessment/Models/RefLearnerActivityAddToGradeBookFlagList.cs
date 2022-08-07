//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefLearnerActivityAddToGradeBookFlagList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefLearnerActivityAddToGradeBookFlag Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearnerActivityAddToGradeBookFlagModel"> List
         /// </summary>
        public static List<RefLearnerActivityAddToGradeBookFlagModel> RefLearnerActivityAddToGradeBookFlagList = new List<RefLearnerActivityAddToGradeBookFlagModel>
        {
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("9669de06-be62-403f-b965-be5223d5e4fa"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("8f0368f4-e3be-4003-b463-6abd587b36df"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("6398c1fd-888a-40e0-a69d-c640434cc935"), Code="NotSelected", Description="Not selected", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefLearnerActivityAddToGradeBookFlag Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearnerActivityAddToGradeBookFlagViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("9669de06-be62-403f-b965-be5223d5e4fa"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("8f0368f4-e3be-4003-b463-6abd587b36df"), Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("6398c1fd-888a-40e0-a69d-c640434cc935"), Description="Not selected", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
