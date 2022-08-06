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
        public static List<RefDisciplineMethodOfCwd> RefDisciplineMethodOfCwdList = new List<RefDisciplineMethodOfCwd> =
        {
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("4a267e3a-4d38-4c33-8f13-a12a30dbfa9c"), Code="Out of School Suspensions/Expulsions - removal from regular school for disciplinary purposes temporarily, for the remainder of the school year, or longer according to LEA policy.", Description="OutOfSchool", Definition="", SortOrder=0 },
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("c042696e-6bdf-4e60-b77b-8d6256a90ecd"), Code="In School Suspensions - temporary removal from regular classroom(s) for disciplinary purposes but still under supervision of school personnel.", Description="InSchool", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefDisciplineMethodOfCwd Pick List
         /// </summary>
        public static List<RefDisciplineMethodOfCwd> RefDisciplineMethodOfCwdPickList = new List<RefDisciplineMethodOfCwd> =
        {
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("4a267e3a-4d38-4c33-8f13-a12a30dbfa9c"), Code="Out of School Suspensions/Expulsions - removal from regular school for disciplinary purposes temporarily, for the remainder of the school year, or longer according to LEA policy.", SortOrder=0 },
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("c042696e-6bdf-4e60-b77b-8d6256a90ecd"), Code="In School Suspensions - temporary removal from regular classroom(s) for disciplinary purposes but still under supervision of school personnel.", SortOrder=0 },
       };
   }
}
