//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEdFactsAcademicOrCareerAndTechnicalOutcomeType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeType"> List
         /// </summary>
        public static List<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType> RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeList = new List<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType>
        {
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("97949870-a738-497a-8425-6535e824adfc"), Code="EARNGED", Description="Earned a GED", Definition="The student earned a GED while enrolled in the program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("48dd3c31-3a91-46a5-aeb5-0fb1700c479c"), Code="EARNCRE", Description="Earned high school course credits", Definition="The student earned high school course credits while enrolled in the program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("916d9fd5-7658-47a5-a08d-da7d145b029a"), Code="ENROLLGED", Description="Enrolled in a GED program", Definition="The student enrolled in a GED program while enrolled in the program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("aa226caa-56cb-4afc-8623-c5b22668f828"), Code="ENROLLTRAIN", Description="Enrolled in job training courses/programs", Definition="The student enrolled in job training courses/programs while enrolled in the program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("2acd88cf-7c61-40b7-9d7d-c0c88681ce42"), Code="OBTAINEMP", Description="Obtained employment", Definition="The student obtained employment while enrolled in the program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("2b6f160b-a2ca-45aa-90c3-921e9302f799"), Code="EARNDIPL", Description="Obtained high school diploma", Definition="The student obtained a high school diploma while enrolled in the program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("2f5652b5-68d2-44c8-af61-bcb93e4a8680"), Code="POSTSEC", Description="Were accepted and/or enrolled into postsecondary education", Definition="The student was accepted and/or enrolled into postsecondary education while enrolled in the program.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefEdFactsAcademicOrCareerAndTechnicalOutcomeType Pick List
         /// </summary>
        public static List<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType> RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypePickList = new List<RefEdFactsAcademicOrCareerAndTechnicalOutcomeType>
        {
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("97949870-a738-497a-8425-6535e824adfc"), Code="EARNGED", Description="Earned a GED", SortOrder=Convert.ToDecimal("1.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("48dd3c31-3a91-46a5-aeb5-0fb1700c479c"), Code="EARNCRE", Description="Earned high school course credits", SortOrder=Convert.ToDecimal("2.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("916d9fd5-7658-47a5-a08d-da7d145b029a"), Code="ENROLLGED", Description="Enrolled in a GED program", SortOrder=Convert.ToDecimal("3.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("aa226caa-56cb-4afc-8623-c5b22668f828"), Code="ENROLLTRAIN", Description="Enrolled in job training courses/programs", SortOrder=Convert.ToDecimal("4.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("2acd88cf-7c61-40b7-9d7d-c0c88681ce42"), Code="OBTAINEMP", Description="Obtained employment", SortOrder=Convert.ToDecimal("5.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("2b6f160b-a2ca-45aa-90c3-921e9302f799"), Code="EARNDIPL", Description="Obtained high school diploma", SortOrder=Convert.ToDecimal("6.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("2f5652b5-68d2-44c8-af61-bcb93e4a8680"), Code="POSTSEC", Description="Were accepted and/or enrolled into postsecondary education", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
