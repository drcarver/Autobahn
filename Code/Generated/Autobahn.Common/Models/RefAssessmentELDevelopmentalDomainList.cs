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
        public static List<RefAssessmentELDevelopmentalDomain> RefAssessmentELDevelopmentalDomainList = new List<RefAssessmentELDevelopmentalDomain>
        {
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("bbf032e9-ba82-49a5-9a69-f71035197068"), Code="01", Description="Language and Literacy", Definition="Domain related to a child's language and literacy development.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("27ad9576-618b-478c-b56f-0ee1fbcfa85d"), Code="02", Description="Cognition and General Knowledge", Definition="Domain related to a child's cognition and general knowledge (including early mathematics and early scientific development).", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("6c57e224-d89a-4631-bd7f-2b7cf09ae9c2"), Code="03", Description="Approaches Toward Learning", Definition="Domain related to a child's approaches toward learning (including the utilization of the arts).", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("5089f813-39fe-45f1-9787-0fe3ce91834b"), Code="04", Description="Physical Well-being and Motor", Definition="Domain related to a child's physical well-being and motor development (including adaptive skills).", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("00bab5f9-2969-489e-bcb2-6de9ba20cfd6"), Code="05", Description="Social and Emotional Development", Definition="Domain related to a child's social and emotional development.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefAssessmentELDevelopmentalDomain Pick List
         /// </summary>
        public static List<RefAssessmentELDevelopmentalDomain> RefAssessmentELDevelopmentalDomainPickList = new List<RefAssessmentELDevelopmentalDomain>
        {
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("bbf032e9-ba82-49a5-9a69-f71035197068"), Code="01", Description="Language and Literacy", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("27ad9576-618b-478c-b56f-0ee1fbcfa85d"), Code="02", Description="Cognition and General Knowledge", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("6c57e224-d89a-4631-bd7f-2b7cf09ae9c2"), Code="03", Description="Approaches Toward Learning", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("5089f813-39fe-45f1-9787-0fe3ce91834b"), Code="04", Description="Physical Well-being and Motor", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("00bab5f9-2969-489e-bcb2-6de9ba20cfd6"), Code="05", Description="Social and Emotional Development", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
