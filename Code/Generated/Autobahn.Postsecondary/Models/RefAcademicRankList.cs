//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefAcademicRankList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefAcademicRank Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicRankModel"> List
         /// </summary>
        public static List<RefAcademicRankModel> RefAcademicRankList = new List<RefAcademicRankModel>
        {
            new RefAcademicRank { Id=Guid.Parse("a1fb5726-9eb9-4c0b-bb2f-43b12e7cd2ba"), Code="Professor", Description="Professor", Definition="Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicRank { Id=Guid.Parse("ef1a666c-34a8-4454-a10d-54c2b313d2d4"), Code="AssociateProfessor", Description="Associate Professor", Definition="Associate Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicRank { Id=Guid.Parse("d754dfab-dfbe-409e-af97-37458fb8de47"), Code="AssistantProfessor", Description="Assistant Professor", Definition="Assistant Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicRank { Id=Guid.Parse("37c40a3b-4557-4ca1-b92e-aa1a9c160268"), Code="Instructor", Description="Instructor", Definition="Instructor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicRank { Id=Guid.Parse("e093cfe2-80c3-4395-a8f6-be18afd87197"), Code="Lecturer", Description="Lecturer", Definition="Lecturer is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicRank { Id=Guid.Parse("f625db79-0a2f-480e-abd4-68a92664fb43"), Code="NoAcademicRank", Description="No Academic Rank", Definition="No Academic Rank is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefAcademicRank Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAcademicRankViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAcademicRank { Id=Guid.Parse("a1fb5726-9eb9-4c0b-bb2f-43b12e7cd2ba"), Description="Professor", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicRank { Id=Guid.Parse("ef1a666c-34a8-4454-a10d-54c2b313d2d4"), Description="Associate Professor", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicRank { Id=Guid.Parse("d754dfab-dfbe-409e-af97-37458fb8de47"), Description="Assistant Professor", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicRank { Id=Guid.Parse("37c40a3b-4557-4ca1-b92e-aa1a9c160268"), Description="Instructor", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicRank { Id=Guid.Parse("e093cfe2-80c3-4395-a8f6-be18afd87197"), Description="Lecturer", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicRank { Id=Guid.Parse("f625db79-0a2f-480e-abd4-68a92664fb43"), Description="No Academic Rank", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
