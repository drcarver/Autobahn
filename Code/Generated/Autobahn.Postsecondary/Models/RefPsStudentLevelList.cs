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
        public static List<RefPsStudentLevel> RefPsStudentLevelList = new List<RefPsStudentLevel>
        {
            new RefPsStudentLevel { Id=Guid.Parse("6bdfc755-a41a-4c23-b500-0e6a0e03d006"), Code="Undergraduate", Description="Undergraduate", Definition="The person enrolling in credit-granting courses at the postsecondary institution is at the undergraduate level.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsStudentLevel { Id=Guid.Parse("d90dfe49-4d2c-4660-97e4-f063c29ca4ef"), Code="Graduate", Description="Graduate", Definition="The person enrolling in credit-granting courses at the postsecondary institution is at the graduate level.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefPsStudentLevel Pick List
         /// </summary>
        public static List<RefPsStudentLevel> RefPsStudentLevelPickList = new List<RefPsStudentLevel>
        {
            new RefPsStudentLevel { Id=Guid.Parse("6bdfc755-a41a-4c23-b500-0e6a0e03d006"), Code="Undergraduate", Description="Undergraduate", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsStudentLevel { Id=Guid.Parse("d90dfe49-4d2c-4660-97e4-f063c29ca4ef"), Code="Graduate", Description="Graduate", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
