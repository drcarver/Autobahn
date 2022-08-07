//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEdFactsAcademicOrCareerAndTechnicalOutcomeType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeModel"> List
         /// </summary>
        public static List<RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeModel> RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeList = new List<RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeModel>
        {
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("48e1af01-f141-4ada-9d28-305a75339fc6"), Code="EARNGED", Description="Earned a GED", Definition="The student earned a GED while enrolled in the program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("6c757556-e916-4916-a681-c4f6b9c055aa"), Code="EARNCRE", Description="Earned high school course credits", Definition="The student earned high school course credits while enrolled in the program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("bf10d426-aba0-4dfb-8905-550d62b2ead4"), Code="ENROLLGED", Description="Enrolled in a GED program", Definition="The student enrolled in a GED program while enrolled in the program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("6cf82ccc-d0a8-434a-9da8-ff0e8cbdcc88"), Code="ENROLLTRAIN", Description="Enrolled in job training courses/programs", Definition="The student enrolled in job training courses/programs while enrolled in the program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("22f342d6-1c4c-4fc6-bb07-532774ade896"), Code="OBTAINEMP", Description="Obtained employment", Definition="The student obtained employment while enrolled in the program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("330c7119-22b6-47f4-94fd-e35c4a05974c"), Code="EARNDIPL", Description="Obtained high school diploma", Definition="The student obtained a high school diploma while enrolled in the program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("c5542415-33dd-41fa-9c60-8a14e5baed00"), Code="POSTSEC", Description="Were accepted and/or enrolled into postsecondary education", Definition="The student was accepted and/or enrolled into postsecondary education while enrolled in the program.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefEdFactsAcademicOrCareerAndTechnicalOutcomeType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("48e1af01-f141-4ada-9d28-305a75339fc6"), Description="Earned a GED", SortOrder=Convert.ToDecimal("1.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("6c757556-e916-4916-a681-c4f6b9c055aa"), Description="Earned high school course credits", SortOrder=Convert.ToDecimal("2.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("bf10d426-aba0-4dfb-8905-550d62b2ead4"), Description="Enrolled in a GED program", SortOrder=Convert.ToDecimal("3.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("6cf82ccc-d0a8-434a-9da8-ff0e8cbdcc88"), Description="Enrolled in job training courses/programs", SortOrder=Convert.ToDecimal("4.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("22f342d6-1c4c-4fc6-bb07-532774ade896"), Description="Obtained employment", SortOrder=Convert.ToDecimal("5.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("330c7119-22b6-47f4-94fd-e35c4a05974c"), Description="Obtained high school diploma", SortOrder=Convert.ToDecimal("6.00") },
            new RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { Id=Guid.Parse("c5542415-33dd-41fa-9c60-8a14e5baed00"), Description="Were accepted and/or enrolled into postsecondary education", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
