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
        public static List<RefIndividualizedProgramTransitionType> RefIndividualizedProgramTransitionTypeList = new List<RefIndividualizedProgramTransitionType> =
        {
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("3102e049-d439-481a-98f4-c2d667e9663e"), Code="Postsecondary education or training is the type of post-school transition plan for the student recorded on their Individualized Education Program.", Description="03426", Definition="", SortOrder=0 },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("259c6a32-6991-4f3a-92d0-286177ac3aa7"), Code="Work is the type of post-school transition plan for the student recorded on their Individualized Education Program.", Description="00518", Definition="", SortOrder=0 },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("4bf9d447-d70e-4bcc-b76c-683e89420266"), Code="No post-school transition plan for the student was recorded on their Individualized Education Program.", Description="09998", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIndividualizedProgramTransitionType Pick List
         /// </summary>
        public static List<RefIndividualizedProgramTransitionType> RefIndividualizedProgramTransitionTypePickList = new List<RefIndividualizedProgramTransitionType> =
        {
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("3102e049-d439-481a-98f4-c2d667e9663e"), Code="Postsecondary education or training is the type of post-school transition plan for the student recorded on their Individualized Education Program.", SortOrder=0 },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("259c6a32-6991-4f3a-92d0-286177ac3aa7"), Code="Work is the type of post-school transition plan for the student recorded on their Individualized Education Program.", SortOrder=0 },
            new RefIndividualizedProgramTransitionType { Id=Guid.Parse("4bf9d447-d70e-4bcc-b76c-683e89420266"), Code="No post-school transition plan for the student was recorded on their Individualized Education Program.", SortOrder=0 },
       };
   }
}
