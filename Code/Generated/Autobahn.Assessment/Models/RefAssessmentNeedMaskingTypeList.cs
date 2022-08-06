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
        public static List<RefAssessmentNeedMaskingType> RefAssessmentNeedMaskingTypeList = new List<RefAssessmentNeedMaskingType> =
        {
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("41ead079-6d80-498d-b724-b3a0112f8f93"), Code="Custom mask is specified as part of an Assessment Personal Needs Profile as the type of masks the user is able to create to cover portions of the question until needed.", Description="CustomMask", Definition="", SortOrder=0 },
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("fafe6005-6ffa-438d-bbf2-9db00ca84ade"), Code="Answer mask is specified as part of an Assessment Personal Needs Profile as the type of masks the user is able to create to cover portions of the question until needed.", Description="AnswerMask", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedMaskingType Pick List
         /// </summary>
        public static List<RefAssessmentNeedMaskingType> RefAssessmentNeedMaskingTypePickList = new List<RefAssessmentNeedMaskingType> =
        {
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("41ead079-6d80-498d-b724-b3a0112f8f93"), Code="Custom mask is specified as part of an Assessment Personal Needs Profile as the type of masks the user is able to create to cover portions of the question until needed.", SortOrder=0 },
            new RefAssessmentNeedMaskingType { Id=Guid.Parse("fafe6005-6ffa-438d-bbf2-9db00ca84ade"), Code="Answer mask is specified as part of an Assessment Personal Needs Profile as the type of masks the user is able to create to cover portions of the question until needed.", SortOrder=0 },
       };
   }
}
