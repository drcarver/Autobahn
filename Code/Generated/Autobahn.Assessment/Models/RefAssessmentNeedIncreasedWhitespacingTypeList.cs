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
        /// The complete <see cref="RefAssessmentNeedIncreasedWhitespacingTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedIncreasedWhitespacingTypeModel> RefAssessmentNeedIncreasedWhitespacingTypeList = new List<RefAssessmentNeedIncreasedWhitespacingTypeModel>
        {
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("ca1b9dda-982b-4e19-89b7-2a87e49a795d"), Code="Line", Description="Line", Definition="Line is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("c3a7ff22-f4f9-40a0-bbb6-ce2085bf0a1a"), Code="Word", Description="Word", Definition="Word is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("b38c28be-abcf-462b-a7d4-905eb193975d"), Code="Character", Description="Character", Definition="Character is specified as the user preferences for increased white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedIncreasedWhitespacingType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedIncreasedWhitespacingTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("ca1b9dda-982b-4e19-89b7-2a87e49a795d"), Description="Line", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("c3a7ff22-f4f9-40a0-bbb6-ce2085bf0a1a"), Description="Word", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedIncreasedWhitespacingType { Id=Guid.Parse("b38c28be-abcf-462b-a7d4-905eb193975d"), Description="Character", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
