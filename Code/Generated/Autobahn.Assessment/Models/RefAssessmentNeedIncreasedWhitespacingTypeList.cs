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
        public static List<RefAssessmentNeedIncreasedWhitespacingType> RefAssessmentNeedIncreasedWhitespacingTypeList = new List<RefAssessmentNeedIncreasedWhitespacingType> =
        {
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("64085a62-1a8a-4dcf-9544-da1be7dfc22e"), Code="Line is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", Description="Line", Definition="", SortOrder=0 },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("1e6eae3a-a8a4-4157-9ebd-e25d1cb82b12"), Code="Word is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", Description="Word", Definition="", SortOrder=0 },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("81a5fe36-caee-4410-b4bc-bc5024077eb9"), Code="Character is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", Description="Character", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedIncreasedWhitespacingType Pick List
         /// </summary>
        public static List<RefAssessmentNeedIncreasedWhitespacingType> RefAssessmentNeedIncreasedWhitespacingTypePickList = new List<RefAssessmentNeedIncreasedWhitespacingType> =
        {
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("64085a62-1a8a-4dcf-9544-da1be7dfc22e"), Code="Line is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", SortOrder=0 },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("1e6eae3a-a8a4-4157-9ebd-e25d1cb82b12"), Code="Word is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", SortOrder=0 },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("81a5fe36-caee-4410-b4bc-bc5024077eb9"), Code="Character is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", SortOrder=0 },
       };
   }
}
