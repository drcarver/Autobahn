//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedMaskingTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedMaskingType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedMaskingType"> List
         /// </summary>
        public static List<RefAssessmentNeedMaskingType> RefAssessmentNeedMaskingTypeList = new List<RefAssessmentNeedMaskingType>
        {
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("e5c3fa45-29af-4b5f-a773-4bf6c487602e"), Code="CustomMask", Description="Custom mask", Definition="Custom mask is specified as part of an Assessment Personal Needs Profile as the type of masks the user is able to create to cover portions of the question until needed.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("5e8dedea-7a79-4bc5-badc-d8d69170a9ae"), Code="AnswerMask", Description="Answer mask", Definition="Answer mask is specified as part of an Assessment Personal Needs Profile as the type of masks the user is able to create to cover portions of the question until needed.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedMaskingType Pick List
         /// </summary>
        public static List<RefAssessmentNeedMaskingType> RefAssessmentNeedMaskingTypePickList = new List<RefAssessmentNeedMaskingType>
        {
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("e5c3fa45-29af-4b5f-a773-4bf6c487602e"), Code="CustomMask", Description="Custom mask", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("5e8dedea-7a79-4bc5-badc-d8d69170a9ae"), Code="AnswerMask", Description="Answer mask", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
