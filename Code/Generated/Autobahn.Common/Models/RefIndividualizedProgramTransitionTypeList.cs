//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIndividualizedProgramTransitionTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIndividualizedProgramTransitionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIndividualizedProgramTransitionTypeModel"> List
         /// </summary>
        public static List<RefIndividualizedProgramTransitionTypeModel> RefIndividualizedProgramTransitionTypeList = new List<RefIndividualizedProgramTransitionTypeModel>
        {
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("b3b77c20-3353-463a-8081-5c7b980bb7f9"), Code="03426", Description="Postsecondary education or training", Definition="Postsecondary education or training is the type of post-school transition plan for the student recorded on their Individualized Education Program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("d3c992b1-a6c5-4611-8538-4e0c9b1b6b72"), Code="00518", Description="Work", Definition="Work is the type of post-school transition plan for the student recorded on their Individualized Education Program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("a2a73e36-0b9c-44f7-860b-e0f978b0f9b6"), Code="09998", Description="None", Definition="No post-school transition plan for the student was recorded on their Individualized Education Program.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefIndividualizedProgramTransitionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIndividualizedProgramTransitionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("b3b77c20-3353-463a-8081-5c7b980bb7f9"), Description="Postsecondary education or training", SortOrder=Convert.ToDecimal("1.00") },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("d3c992b1-a6c5-4611-8538-4e0c9b1b6b72"), Description="Work", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("a2a73e36-0b9c-44f7-860b-e0f978b0f9b6"), Description="None", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
