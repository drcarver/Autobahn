//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefDisciplineMethodOfCwdList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefDisciplineMethodOfCwd Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDisciplineMethodOfCwd"> List
         /// </summary>
        public static List<RefDisciplineMethodOfCwd> RefDisciplineMethodOfCwdList = new List<RefDisciplineMethodOfCwd>
        {
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("1187b725-03ec-4fc4-99fb-8786b5781e01"), Code="OutOfSchool", Description="Out of School Suspensions/Expulsions", Definition="Out of School Suspensions/Expulsions - removal from regular school for disciplinary purposes temporarily, for the remainder of the school year, or longer according to LEA policy.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("3f8278ac-3033-4de6-8049-7ce17c5e7dad"), Code="InSchool", Description="In School Suspensions", Definition="In School Suspensions - temporary removal from regular classroom(s) for disciplinary purposes but still under supervision of school personnel.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefDisciplineMethodOfCwd Pick List
         /// </summary>
        public static List<RefDisciplineMethodOfCwd> RefDisciplineMethodOfCwdPickList = new List<RefDisciplineMethodOfCwd>
        {
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("1187b725-03ec-4fc4-99fb-8786b5781e01"), Code="OutOfSchool", Description="Out of School Suspensions/Expulsions", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("3f8278ac-3033-4de6-8049-7ce17c5e7dad"), Code="InSchool", Description="In School Suspensions", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
