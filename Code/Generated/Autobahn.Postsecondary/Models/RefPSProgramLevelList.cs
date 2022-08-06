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
        /// The complete <see cref="RefPSProgramLevel"> List
         /// </summary>
        public static List<RefPSProgramLevel> RefPSProgramLevelList = new List<RefPSProgramLevel> =
        {
            new RefPSProgramLevel { Id=Guid.Parse("2df11ec5-9609-4b04-95b8-e98ac4fabca4"), Code="Major is the  concentration of study for the postsecondary program.", Description="Major", Definition="", SortOrder=0 },
            new RefPSProgramLevel { Id=Guid.Parse("7e1f8c6b-1db3-4e33-a1a0-26563dc3f3b0"), Code="Minor is the  concentration of study for the postsecondary program.", Description="Minor", Definition="", SortOrder=0 },
            new RefPSProgramLevel { Id=Guid.Parse("02fc7f3e-45a1-409c-84a2-8be64b68875a"), Code="Certificate is the  concentration of study for the postsecondary program.", Description="Certificate", Definition="", SortOrder=0 },
            new RefPSProgramLevel { Id=Guid.Parse("6c717b02-4851-463f-a283-14a04cfcd04b"), Code="The concentration of study for the postsecondary program is in a category not yet defined in CEDS. ", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPSProgramLevel Pick List
         /// </summary>
        public static List<RefPSProgramLevel> RefPSProgramLevelPickList = new List<RefPSProgramLevel> =
        {
            new RefPSProgramLevel { Id=Guid.Parse("2df11ec5-9609-4b04-95b8-e98ac4fabca4"), Code="Major is the  concentration of study for the postsecondary program.", SortOrder=0 },
            new RefPSProgramLevel { Id=Guid.Parse("7e1f8c6b-1db3-4e33-a1a0-26563dc3f3b0"), Code="Minor is the  concentration of study for the postsecondary program.", SortOrder=0 },
            new RefPSProgramLevel { Id=Guid.Parse("02fc7f3e-45a1-409c-84a2-8be64b68875a"), Code="Certificate is the  concentration of study for the postsecondary program.", SortOrder=0 },
            new RefPSProgramLevel { Id=Guid.Parse("6c717b02-4851-463f-a283-14a04cfcd04b"), Code="The concentration of study for the postsecondary program is in a category not yet defined in CEDS. ", SortOrder=0 },
       };
   }
}
