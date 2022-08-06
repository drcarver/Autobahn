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
        public static List<RefAssessmentNeedSigningType> RefAssessmentNeedSigningTypeList = new List<RefAssessmentNeedSigningType>
        {
            new RefAssessmentNeedSigningType { Id=Guid.Parse("6127d355-28ff-437a-8551-7214284e2599"), Code="ASL", Description="American Sign Language", Definition="American Sign Language is specified as part of an Assessment Personal Needs Profile as the type of signing preferred by the user.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSigningType { Id=Guid.Parse("d20ec64b-76d3-4431-a086-d52cd2693aaf"), Code="SignedEnglish", Description="Signed English", Definition="Signed English is specified as part of an Assessment Personal Needs Profile as the type of signing preferred by the user.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedSigningType Pick List
         /// </summary>
        public static List<RefAssessmentNeedSigningType> RefAssessmentNeedSigningTypePickList = new List<RefAssessmentNeedSigningType>
        {
            new RefAssessmentNeedSigningType { Id=Guid.Parse("6127d355-28ff-437a-8551-7214284e2599"), Code="ASL", Description="American Sign Language", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSigningType { Id=Guid.Parse("d20ec64b-76d3-4431-a086-d52cd2693aaf"), Code="SignedEnglish", Description="Signed English", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
