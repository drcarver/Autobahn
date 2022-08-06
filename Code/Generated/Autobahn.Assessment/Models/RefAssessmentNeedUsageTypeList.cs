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
        public static List<RefAssessmentNeedUsageType> RefAssessmentNeedUsageTypeList = new List<RefAssessmentNeedUsageType> =
        {
            new RefAssessmentNeedUsageType { Id=Guid.Parse("4c121e7e-0e07-4cb3-8fd0-8a65d5b9a2dd"), Code="Required is specified as the rating for the collection of Access for All (AfA) needs and preferences.", Description="Required", Definition="", SortOrder=0 },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("095e6a22-eda9-4006-b5b5-c27a2d1c243e"), Code="Preferred is specified as the rating for the collection of Access for All (AfA) needs and preferences.", Description="Preferred", Definition="", SortOrder=0 },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("bee0424d-5651-4e58-8482-7a3849dd0d51"), Code="Optionally  use is specified as the rating for the collection of Access for All (AfA) needs and preferences.", Description="OptionallyUse", Definition="", SortOrder=0 },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("340fd456-6d95-4688-8793-d96b3e4320bd"), Code="Prohibited is specified as the rating for the collection of Access for All (AfA) needs and preferences.", Description="Prohibited", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedUsageType Pick List
         /// </summary>
        public static List<RefAssessmentNeedUsageType> RefAssessmentNeedUsageTypePickList = new List<RefAssessmentNeedUsageType> =
        {
            new RefAssessmentNeedUsageType { Id=Guid.Parse("4c121e7e-0e07-4cb3-8fd0-8a65d5b9a2dd"), Code="Required is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=0 },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("095e6a22-eda9-4006-b5b5-c27a2d1c243e"), Code="Preferred is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=0 },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("bee0424d-5651-4e58-8482-7a3849dd0d51"), Code="Optionally  use is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=0 },
            new RefAssessmentNeedUsageType { Id=Guid.Parse("340fd456-6d95-4688-8793-d96b3e4320bd"), Code="Prohibited is specified as the rating for the collection of Access for All (AfA) needs and preferences.", SortOrder=0 },
       };
   }
}
