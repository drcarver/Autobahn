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
        /// The complete <see cref="RefAssessmentNeedSigningType"> List
         /// </summary>
        public static List<RefAssessmentNeedSigningType> RefAssessmentNeedSigningTypeList = new List<RefAssessmentNeedSigningType> =
        {
            new RefAssessmentNeedSigningType { Id=Guid.Parse("12e50b64-d93c-426f-923d-a73f11e8f0ef"), Code="American Sign Language is specified as part of an Assessment Personal Needs Profile as the type of signing preferred by the user.", Description="ASL", Definition="", SortOrder=0 },
            new RefAssessmentNeedSigningType { Id=Guid.Parse("1fecd0ba-305d-4989-9807-34802c58ab38"), Code="Signed English is specified as part of an Assessment Personal Needs Profile as the type of signing preferred by the user.", Description="SignedEnglish", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedSigningType Pick List
         /// </summary>
        public static List<RefAssessmentNeedSigningType> RefAssessmentNeedSigningTypePickList = new List<RefAssessmentNeedSigningType> =
        {
            new RefAssessmentNeedSigningType { Id=Guid.Parse("12e50b64-d93c-426f-923d-a73f11e8f0ef"), Code="American Sign Language is specified as part of an Assessment Personal Needs Profile as the type of signing preferred by the user.", SortOrder=0 },
            new RefAssessmentNeedSigningType { Id=Guid.Parse("1fecd0ba-305d-4989-9807-34802c58ab38"), Code="Signed English is specified as part of an Assessment Personal Needs Profile as the type of signing preferred by the user.", SortOrder=0 },
       };
   }
}
