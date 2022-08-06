//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefAePostsecondaryTransitionActionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The list of RefAePostsecondaryTransitionAction Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAePostsecondaryTransitionAction"> List
         /// </summary>
        public static List<RefAePostsecondaryTransitionAction> RefAePostsecondaryTransitionActionList = new List<RefAePostsecondaryTransitionAction> =
        {
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("7b93a793-7fe9-4b88-bbd8-c60acdb53c46"), Code="No information is available with respect to postsecondary enrollment by the learner after program exit or when co-enrolled in ABE and postsecondary.", Description="NoInformation", Definition="", SortOrder=0 },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("2bce1388-0e34-4610-b781-ef8480a6d32c"), Code="The learner enrolled in a postsecondary educational or occupational skills program building on prior services or training received.", Description="Enrolled", Definition="", SortOrder=0 },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("204bf75f-5bb1-4548-8520-2d2b3dd24b90"), Code="The learner has not enrolled in a postsecondary educational or occupational skills program building on prior services or training received.", Description="NotEnrolled", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAePostsecondaryTransitionAction Pick List
         /// </summary>
        public static List<RefAePostsecondaryTransitionAction> RefAePostsecondaryTransitionActionPickList = new List<RefAePostsecondaryTransitionAction> =
        {
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("7b93a793-7fe9-4b88-bbd8-c60acdb53c46"), Code="No information is available with respect to postsecondary enrollment by the learner after program exit or when co-enrolled in ABE and postsecondary.", SortOrder=0 },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("2bce1388-0e34-4610-b781-ef8480a6d32c"), Code="The learner enrolled in a postsecondary educational or occupational skills program building on prior services or training received.", SortOrder=0 },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("204bf75f-5bb1-4548-8520-2d2b3dd24b90"), Code="The learner has not enrolled in a postsecondary educational or occupational skills program building on prior services or training received.", SortOrder=0 },
       };
   }
}
