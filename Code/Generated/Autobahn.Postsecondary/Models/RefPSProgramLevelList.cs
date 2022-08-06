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
        public static List<RefPSProgramLevel> RefPSProgramLevelList = new List<RefPSProgramLevel>
        {
            new RefPSProgramLevel { Id=Guid.Parse("e9d76f1f-f8c6-4b60-81f4-f0f3d619e72d"), Code="Major", Description="Major", Definition="Major is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPSProgramLevel { Id=Guid.Parse("1a951568-33bc-438e-82ca-5a267562d1ac"), Code="Minor", Description="Minor", Definition="Minor is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPSProgramLevel { Id=Guid.Parse("53a5e765-ca23-41d3-98b0-fac2cac006c8"), Code="Certificate", Description="Certificate", Definition="Certificate is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPSProgramLevel { Id=Guid.Parse("d1c5ffbb-071c-4ade-95fd-b6034f2e097f"), Code="Other", Description="Other", Definition="The concentration of study for the postsecondary program is in a category not yet defined in CEDS. ", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefPSProgramLevel Pick List
         /// </summary>
        public static List<RefPSProgramLevel> RefPSProgramLevelPickList = new List<RefPSProgramLevel>
        {
            new RefPSProgramLevel { Id=Guid.Parse("e9d76f1f-f8c6-4b60-81f4-f0f3d619e72d"), Code="Major", Description="Major", SortOrder=Convert.ToDecimal("1.00") },
            new RefPSProgramLevel { Id=Guid.Parse("1a951568-33bc-438e-82ca-5a267562d1ac"), Code="Minor", Description="Minor", SortOrder=Convert.ToDecimal("3.00") },
            new RefPSProgramLevel { Id=Guid.Parse("53a5e765-ca23-41d3-98b0-fac2cac006c8"), Code="Certificate", Description="Certificate", SortOrder=Convert.ToDecimal("5.00") },
            new RefPSProgramLevel { Id=Guid.Parse("d1c5ffbb-071c-4ade-95fd-b6034f2e097f"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
