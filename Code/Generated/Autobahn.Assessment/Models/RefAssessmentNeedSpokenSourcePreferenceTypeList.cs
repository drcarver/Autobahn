//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedSpokenSourcePreferenceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedSpokenSourcePreferenceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedSpokenSourcePreferenceTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedSpokenSourcePreferenceTypeModel> RefAssessmentNeedSpokenSourcePreferenceTypeList = new List<RefAssessmentNeedSpokenSourcePreferenceTypeModel>
        {
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("46d4cb1e-1e94-4a64-bd21-3234857ee8dc"), Code="Human", Description="Human", Definition="Human is specified as the preferred spoken audio form  as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("aa3224e6-7d24-452c-9709-2a7597a03cad"), Code="Synthetic", Description="Synthetic", Definition="Synthetic is specified as the preferred spoken audio form  as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedSpokenSourcePreferenceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedSpokenSourcePreferenceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("46d4cb1e-1e94-4a64-bd21-3234857ee8dc"), Description="Human", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("aa3224e6-7d24-452c-9709-2a7597a03cad"), Description="Synthetic", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
