//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedSigningTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedSigningType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedSigningTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedSigningTypeModel> RefAssessmentNeedSigningTypeList = new List<RefAssessmentNeedSigningTypeModel>
        {
            new RefAssessmentNeedSigningType { Id=Guid.Parse("b829d86e-cf13-43f3-a0f0-85051284d520"), Code="ASL", Description="American Sign Language", Definition="American Sign Language is specified as part of an Assessment Personal Needs Profile as the type of signing preferred by the user.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSigningType { Id=Guid.Parse("84bde7f2-620f-488a-bed6-5af7977bcb7f"), Code="SignedEnglish", Description="Signed English", Definition="Signed English is specified as part of an Assessment Personal Needs Profile as the type of signing preferred by the user.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedSigningType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedSigningTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedSigningType { Id=Guid.Parse("b829d86e-cf13-43f3-a0f0-85051284d520"), Description="American Sign Language", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSigningType { Id=Guid.Parse("84bde7f2-620f-488a-bed6-5af7977bcb7f"), Description="Signed English", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
