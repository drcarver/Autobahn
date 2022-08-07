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
        /// The complete <see cref="RefDisciplineMethodOfCwdModel"> List
         /// </summary>
        public static List<RefDisciplineMethodOfCwdModel> RefDisciplineMethodOfCwdList = new List<RefDisciplineMethodOfCwdModel>
        {
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("94ab646b-f92b-4c9a-981c-e785c6c502a4"), Code="OutOfSchool", Description="Out of School Suspensions/Expulsions", Definition="Out of School Suspensions/Expulsions - removal from regular school for disciplinary purposes temporarily, for the remainder of the school year, or longer according to LEA policy.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("65ba0a58-1315-4809-b522-030f2f6dc551"), Code="InSchool", Description="In School Suspensions", Definition="In School Suspensions - temporary removal from regular classroom(s) for disciplinary purposes but still under supervision of school personnel.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefDisciplineMethodOfCwd Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDisciplineMethodOfCwdViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("94ab646b-f92b-4c9a-981c-e785c6c502a4"), Description="Out of School Suspensions/Expulsions", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineMethodOfCwd { Id=Guid.Parse("65ba0a58-1315-4809-b522-030f2f6dc551"), Description="In School Suspensions", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
