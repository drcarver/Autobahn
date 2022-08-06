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
        public static List<RefAePostsecondaryTransitionAction> RefAePostsecondaryTransitionActionList = new List<RefAePostsecondaryTransitionAction>
        {
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("e46afc1a-244d-4586-83b2-b4a226514f92"), Code="NoInformation", Description="No information", Definition="No information is available with respect to postsecondary enrollment by the learner after program exit or when co-enrolled in ABE and postsecondary.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("506e5c42-12f7-480e-a982-f74ccea72b9d"), Code="Enrolled", Description="Enrolled", Definition="The learner enrolled in a postsecondary educational or occupational skills program building on prior services or training received.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("9c602d50-b8a4-4098-91cd-ebe03e7886ce"), Code="NotEnrolled", Description="Not enrolled", Definition="The learner has not enrolled in a postsecondary educational or occupational skills program building on prior services or training received.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefAePostsecondaryTransitionAction Pick List
         /// </summary>
        public static List<RefAePostsecondaryTransitionAction> RefAePostsecondaryTransitionActionPickList = new List<RefAePostsecondaryTransitionAction>
        {
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("e46afc1a-244d-4586-83b2-b4a226514f92"), Code="NoInformation", Description="No information", SortOrder=Convert.ToDecimal("1.00") },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("506e5c42-12f7-480e-a982-f74ccea72b9d"), Code="Enrolled", Description="Enrolled", SortOrder=Convert.ToDecimal("2.00") },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("9c602d50-b8a4-4098-91cd-ebe03e7886ce"), Code="NotEnrolled", Description="Not enrolled", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
