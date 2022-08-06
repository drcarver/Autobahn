//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedIncreasedWhitespacingTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedIncreasedWhitespacingType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedIncreasedWhitespacingType"> List
         /// </summary>
        public static List<RefAssessmentNeedIncreasedWhitespacingType> RefAssessmentNeedIncreasedWhitespacingTypeList = new List<RefAssessmentNeedIncreasedWhitespacingType>
        {
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("e905c4fa-e465-4e24-a270-46cddeaeff44"), Code="Line", Description="Line", Definition="Line is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("eb8c1f00-8660-4e59-96ab-c2a38af939d4"), Code="Word", Description="Word", Definition="Word is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("de292093-4555-4408-88c5-01e98d34a66e"), Code="Character", Description="Character", Definition="Character is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedIncreasedWhitespacingType Pick List
         /// </summary>
        public static List<RefAssessmentNeedIncreasedWhitespacingType> RefAssessmentNeedIncreasedWhitespacingTypePickList = new List<RefAssessmentNeedIncreasedWhitespacingType>
        {
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("e905c4fa-e465-4e24-a270-46cddeaeff44"), Code="Line", Description="Line", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("eb8c1f00-8660-4e59-96ab-c2a38af939d4"), Code="Word", Description="Word", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("de292093-4555-4408-88c5-01e98d34a66e"), Code="Character", Description="Character", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
