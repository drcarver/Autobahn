//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPsStudentLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPsStudentLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPsStudentLevel"> List
         /// </summary>
        public static List<RefPsStudentLevel> RefPsStudentLevelList = new List<RefPsStudentLevel> =
        {
            new RefPsStudentLevel { Id=Guid.Parse("fbbf131d-7303-468a-ae38-6dd0b2290a79"), Code="The person enrolling in credit-granting courses at the postsecondary institution is at the undergraduate level.", Description="Undergraduate", Definition="", SortOrder=0 },
            new RefPsStudentLevel { Id=Guid.Parse("543ff89b-7335-43e2-baea-f9415e37de5e"), Code="The person enrolling in credit-granting courses at the postsecondary institution is at the graduate level.", Description="Graduate", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPsStudentLevel Pick List
         /// </summary>
        public static List<RefPsStudentLevel> RefPsStudentLevelPickList = new List<RefPsStudentLevel> =
        {
            new RefPsStudentLevel { Id=Guid.Parse("fbbf131d-7303-468a-ae38-6dd0b2290a79"), Code="The person enrolling in credit-granting courses at the postsecondary institution is at the undergraduate level.", SortOrder=0 },
            new RefPsStudentLevel { Id=Guid.Parse("543ff89b-7335-43e2-baea-f9415e37de5e"), Code="The person enrolling in credit-granting courses at the postsecondary institution is at the graduate level.", SortOrder=0 },
       };
   }
}
