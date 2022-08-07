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
        /// The complete <see cref="RefAePostsecondaryTransitionActionModel"> List
         /// </summary>
        public static List<RefAePostsecondaryTransitionActionModel> RefAePostsecondaryTransitionActionList = new List<RefAePostsecondaryTransitionActionModel>
        {
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("b05ae4c1-f835-4a7e-aaf5-571288adc763"), Code="NoInformation", Description="No information", Definition="No information is available with respect to postsecondary enrollment by the learner after program exit or when co-enrolled in ABE and postsecondary.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("48c762a0-8817-4f4a-9636-10753cf6de8a"), Code="Enrolled", Description="Enrolled", Definition="The learner enrolled in a postsecondary educational or occupational skills program building on prior services or training received.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("9cc1896b-d9a9-45fe-8140-6aff60e154cb"), Code="NotEnrolled", Description="Not enrolled", Definition="The learner has not enrolled in a postsecondary educational or occupational skills program building on prior services or training received.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefAePostsecondaryTransitionAction Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAePostsecondaryTransitionActionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("b05ae4c1-f835-4a7e-aaf5-571288adc763"), Description="No information", SortOrder=Convert.ToDecimal("1.00") },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("48c762a0-8817-4f4a-9636-10753cf6de8a"), Description="Enrolled", SortOrder=Convert.ToDecimal("2.00") },
            new RefAePostsecondaryTransitionAction { Id=Guid.Parse("9cc1896b-d9a9-45fe-8140-6aff60e154cb"), Description="Not enrolled", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
