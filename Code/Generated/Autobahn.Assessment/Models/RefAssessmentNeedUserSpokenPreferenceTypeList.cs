//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedUserSpokenPreferenceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedUserSpokenPreferenceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedUserSpokenPreferenceTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedUserSpokenPreferenceTypeModel> RefAssessmentNeedUserSpokenPreferenceTypeList = new List<RefAssessmentNeedUserSpokenPreferenceTypeModel>
        {
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("a42ad725-1844-4664-b247-4e71d13f818b"), Code="TextOnly", Description="Text only", Definition="Text only is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("5fed63f4-9fb2-47f6-a45d-45974912b980"), Code="TextGraphics", Description="Text and graphics", Definition="Text and graphics is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("1798d59b-0e57-4d93-a722-88f3cb1518c0"), Code="GraphicsOnly", Description="Graphics only", Definition="Graphics only is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("5f573881-16ef-4cb7-81cb-22f70beb4bed"), Code="NonVisual", Description="Non-visual", Definition="Non-visual is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedUserSpokenPreferenceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedUserSpokenPreferenceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("a42ad725-1844-4664-b247-4e71d13f818b"), Description="Text only", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("5fed63f4-9fb2-47f6-a45d-45974912b980"), Description="Text and graphics", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("1798d59b-0e57-4d93-a722-88f3cb1518c0"), Description="Graphics only", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("5f573881-16ef-4cb7-81cb-22f70beb4bed"), Description="Non-visual", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
