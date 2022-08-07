//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPSProgramLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPSProgramLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPSProgramLevelModel"> List
         /// </summary>
        public static List<RefPSProgramLevelModel> RefPSProgramLevelList = new List<RefPSProgramLevelModel>
        {
            new RefPSProgramLevel { Id=Guid.Parse("8a17b292-5797-415a-9b94-d208342a9ccd"), Code="Major", Description="Major", Definition="Major is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPSProgramLevel { Id=Guid.Parse("33bd86ff-4662-4ab7-adbe-1aedaf70f4a4"), Code="Minor", Description="Minor", Definition="Minor is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPSProgramLevel { Id=Guid.Parse("d4f9c4b6-3b9b-4337-93e0-e7324aa53989"), Code="Certificate", Description="Certificate", Definition="Certificate is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPSProgramLevel { Id=Guid.Parse("2a38970b-f155-44eb-b4ab-8e0649d69206"), Code="Other", Description="Other", Definition="The concentration of study for the postsecondary program is in a category not yet defined in CEDS. ", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefPSProgramLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPSProgramLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPSProgramLevel { Id=Guid.Parse("8a17b292-5797-415a-9b94-d208342a9ccd"), Description="Major", SortOrder=Convert.ToDecimal("1.00") },
            new RefPSProgramLevel { Id=Guid.Parse("33bd86ff-4662-4ab7-adbe-1aedaf70f4a4"), Description="Minor", SortOrder=Convert.ToDecimal("3.00") },
            new RefPSProgramLevel { Id=Guid.Parse("d4f9c4b6-3b9b-4337-93e0-e7324aa53989"), Description="Certificate", SortOrder=Convert.ToDecimal("5.00") },
            new RefPSProgramLevel { Id=Guid.Parse("2a38970b-f155-44eb-b4ab-8e0649d69206"), Description="Other", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
