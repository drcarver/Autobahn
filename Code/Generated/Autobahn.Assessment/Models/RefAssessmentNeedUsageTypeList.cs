//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedUsageTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedUsageType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedUsageType"> List
         /// </summary>
        public static List<RefAssessmentNeedUsageType> RefAssessmentNeedUsageTypeList = new List<RefAssessmentNeedUsageType>
        {
            new RefAssessmentNeedUsageType { Id=Guid.Parse("005f62d9-4c11-45a3-bca4-2ec141e92a99"), Code="Required", Description="Required", Definition="Required is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("af521802-5b55-4c8a-851d-992a463be507"), Code="Preferred", Description="Preferred", Definition="Preferred is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("1b8018d1-bdab-434b-947c-629d08f493a4"), Code="OptionallyUse", Description="Optionally  use", Definition="Optionally  use is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("654b0d2a-391e-4725-96dd-69078d54b007"), Code="Prohibited", Description="Prohibited", Definition="Prohibited is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedUsageType Pick List
         /// </summary>
        public static List<RefAssessmentNeedUsageType> RefAssessmentNeedUsageTypePickList = new List<RefAssessmentNeedUsageType>
        {
            new RefAssessmentNeedUsageType { Id=Guid.Parse("005f62d9-4c11-45a3-bca4-2ec141e92a99"), Code="Required", Description="Required", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("af521802-5b55-4c8a-851d-992a463be507"), Code="Preferred", Description="Preferred", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("1b8018d1-bdab-434b-947c-629d08f493a4"), Code="OptionallyUse", Description="Optionally  use", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("654b0d2a-391e-4725-96dd-69078d54b007"), Code="Prohibited", Description="Prohibited", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
