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
        /// The complete <see cref="RefAcademicRank"> List
         /// </summary>
        public static List<RefAcademicRank> RefAcademicRankList = new List<RefAcademicRank>
        {
            new RefAcademicRank { Id=Guid.Parse("7857cc45-dee3-47f0-a4a4-ad33afe3a0f0"), Code="Professor", Description="Professor", Definition="Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicRank { Id=Guid.Parse("329ebe41-caee-4449-b676-1632a9b45624"), Code="AssociateProfessor", Description="Associate Professor", Definition="Associate Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicRank { Id=Guid.Parse("53d9eecc-6a30-41a1-8eee-27b39d5bab77"), Code="AssistantProfessor", Description="Assistant Professor", Definition="Assistant Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicRank { Id=Guid.Parse("9f8515da-eb7d-4296-a7e8-61328486cde4"), Code="Instructor", Description="Instructor", Definition="Instructor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicRank { Id=Guid.Parse("f418a40e-d0bd-4897-8591-f630a2a0de89"), Code="Lecturer", Description="Lecturer", Definition="Lecturer is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicRank { Id=Guid.Parse("c432c711-6f1a-4ecd-8ab4-44efd854196c"), Code="NoAcademicRank", Description="No Academic Rank", Definition="No Academic Rank is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefAcademicRank Pick List
         /// </summary>
        public static List<RefAcademicRank> RefAcademicRankPickList = new List<RefAcademicRank>
        {
            new RefAcademicRank { Id=Guid.Parse("7857cc45-dee3-47f0-a4a4-ad33afe3a0f0"), Code="Professor", Description="Professor", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicRank { Id=Guid.Parse("329ebe41-caee-4449-b676-1632a9b45624"), Code="AssociateProfessor", Description="Associate Professor", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicRank { Id=Guid.Parse("53d9eecc-6a30-41a1-8eee-27b39d5bab77"), Code="AssistantProfessor", Description="Assistant Professor", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicRank { Id=Guid.Parse("9f8515da-eb7d-4296-a7e8-61328486cde4"), Code="Instructor", Description="Instructor", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicRank { Id=Guid.Parse("f418a40e-d0bd-4897-8591-f630a2a0de89"), Code="Lecturer", Description="Lecturer", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicRank { Id=Guid.Parse("c432c711-6f1a-4ecd-8ab4-44efd854196c"), Code="NoAcademicRank", Description="No Academic Rank", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
