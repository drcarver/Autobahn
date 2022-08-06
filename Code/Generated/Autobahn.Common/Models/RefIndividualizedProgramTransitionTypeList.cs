//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIndividualizedProgramTransitionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIndividualizedProgramTransitionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIndividualizedProgramTransitionType"> List
         /// </summary>
        public static List<RefIndividualizedProgramTransitionType> RefIndividualizedProgramTransitionTypeList = new List<RefIndividualizedProgramTransitionType>
        {
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("0e4d41a1-cc8f-4471-ba71-3070f2210af3"), Code="03426", Description="Postsecondary education or training", Definition="Postsecondary education or training is the type of post-school transition plan for the student recorded on their Individualized Education Program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("b46ef99e-400d-4944-a708-48d5271c8d48"), Code="00518", Description="Work", Definition="Work is the type of post-school transition plan for the student recorded on their Individualized Education Program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("97865346-eebf-4f87-8de9-6eb8df67b1ed"), Code="09998", Description="None", Definition="No post-school transition plan for the student was recorded on their Individualized Education Program.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefIndividualizedProgramTransitionType Pick List
         /// </summary>
        public static List<RefIndividualizedProgramTransitionType> RefIndividualizedProgramTransitionTypePickList = new List<RefIndividualizedProgramTransitionType>
        {
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("0e4d41a1-cc8f-4471-ba71-3070f2210af3"), Code="03426", Description="Postsecondary education or training", SortOrder=Convert.ToDecimal("1.00") },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("b46ef99e-400d-4944-a708-48d5271c8d48"), Code="00518", Description="Work", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("97865346-eebf-4f87-8de9-6eb8df67b1ed"), Code="09998", Description="None", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
