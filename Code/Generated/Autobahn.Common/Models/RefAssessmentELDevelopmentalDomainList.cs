//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAssessmentELDevelopmentalDomainList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAssessmentELDevelopmentalDomain Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentELDevelopmentalDomain"> List
         /// </summary>
        public static List<RefAssessmentELDevelopmentalDomain> RefAssessmentELDevelopmentalDomainList = new List<RefAssessmentELDevelopmentalDomain> =
        {
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("4f5ab8ae-dcea-4d67-9936-fcd45d2ce9b5"), Code="Domain related to a child's language and literacy development.", Description="01", Definition="", SortOrder=0 },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("051b672a-80d3-4bd3-930d-0809ec5126e8"), Code="Domain related to a child's cognition and general knowledge (including early mathematics and early scientific development).", Description="02", Definition="", SortOrder=0 },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("92ca795c-b103-4b91-9dad-2c3d62503e43"), Code="Domain related to a child's approaches toward learning (including the utilization of the arts).", Description="03", Definition="", SortOrder=0 },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("43c716e8-1954-4559-8af4-39a82ac4ac9c"), Code="Domain related to a child's physical well-being and motor development (including adaptive skills).", Description="04", Definition="", SortOrder=0 },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("09b39cd2-ae06-454b-a1ef-0e52c052dcda"), Code="Domain related to a child's social and emotional development.", Description="05", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentELDevelopmentalDomain Pick List
         /// </summary>
        public static List<RefAssessmentELDevelopmentalDomain> RefAssessmentELDevelopmentalDomainPickList = new List<RefAssessmentELDevelopmentalDomain> =
        {
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("4f5ab8ae-dcea-4d67-9936-fcd45d2ce9b5"), Code="Domain related to a child's language and literacy development.", SortOrder=0 },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("051b672a-80d3-4bd3-930d-0809ec5126e8"), Code="Domain related to a child's cognition and general knowledge (including early mathematics and early scientific development).", SortOrder=0 },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("92ca795c-b103-4b91-9dad-2c3d62503e43"), Code="Domain related to a child's approaches toward learning (including the utilization of the arts).", SortOrder=0 },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("43c716e8-1954-4559-8af4-39a82ac4ac9c"), Code="Domain related to a child's physical well-being and motor development (including adaptive skills).", SortOrder=0 },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("09b39cd2-ae06-454b-a1ef-0e52c052dcda"), Code="Domain related to a child's social and emotional development.", SortOrder=0 },
       };
   }
}
