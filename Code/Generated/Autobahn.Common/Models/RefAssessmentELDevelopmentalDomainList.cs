//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAssessmentELDevelopmentalDomainList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAssessmentELDevelopmentalDomain Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentELDevelopmentalDomainModel"> List
         /// </summary>
        public static List<RefAssessmentELDevelopmentalDomainModel> RefAssessmentELDevelopmentalDomainList = new List<RefAssessmentELDevelopmentalDomainModel>
        {
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("a853b812-9a26-42fd-8d4f-faecc0297301"), Code="01", Description="Language and Literacy", Definition="Domain related to a child's language and literacy development.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("58314742-bdb8-405b-bff9-9f5e3b01330c"), Code="02", Description="Cognition and General Knowledge", Definition="Domain related to a child's cognition and general knowledge (including early mathematics and early scientific development).", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("548efeff-8a63-449d-8617-8f09ce0f0f3d"), Code="03", Description="Approaches Toward Learning", Definition="Domain related to a child's approaches toward learning (including the utilization of the arts).", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("c5f52b09-4c18-4c0e-ba71-caca133f432b"), Code="04", Description="Physical Well-being and Motor", Definition="Domain related to a child's physical well-being and motor development (including adaptive skills).", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("71a63333-ef4f-474c-89b2-d33c6af42d61"), Code="05", Description="Social and Emotional Development", Definition="Domain related to a child's social and emotional development.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentELDevelopmentalDomain Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentELDevelopmentalDomainViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("a853b812-9a26-42fd-8d4f-faecc0297301"), Description="Language and Literacy", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("58314742-bdb8-405b-bff9-9f5e3b01330c"), Description="Cognition and General Knowledge", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("548efeff-8a63-449d-8617-8f09ce0f0f3d"), Description="Approaches Toward Learning", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("c5f52b09-4c18-4c0e-ba71-caca133f432b"), Description="Physical Well-being and Motor", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentELDevelopmentalDomain { Id=Guid.Parse("71a63333-ef4f-474c-89b2-d33c6af42d61"), Description="Social and Emotional Development", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
