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
        public static List<RefAcademicRank> RefAcademicRankList = new List<RefAcademicRank> =
        {
            new RefAcademicRank { Id=Guid.Parse("279f79a8-bbb8-4eaf-ac9f-98f76a7bf17a"), Code="Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", Description="Professor", Definition="", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("17dfbd98-b9fa-4ffb-8728-6ee9bc3c7a86"), Code="Associate Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", Description="AssociateProfessor", Definition="", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("0fa0a1c9-c24d-4433-b724-c53346a0edb4"), Code="Assistant Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", Description="AssistantProfessor", Definition="", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("ead700d3-b0d4-4f5e-ba6d-7aa887227e49"), Code="Instructor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", Description="Instructor", Definition="", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("04920224-7863-4d50-994a-913dc4ab0003"), Code="Lecturer is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", Description="Lecturer", Definition="", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("5ce783c6-e55a-43cd-8288-e04db008a910"), Code="No Academic Rank is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", Description="NoAcademicRank", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAcademicRank Pick List
         /// </summary>
        public static List<RefAcademicRank> RefAcademicRankPickList = new List<RefAcademicRank> =
        {
            new RefAcademicRank { Id=Guid.Parse("279f79a8-bbb8-4eaf-ac9f-98f76a7bf17a"), Code="Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("17dfbd98-b9fa-4ffb-8728-6ee9bc3c7a86"), Code="Associate Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("0fa0a1c9-c24d-4433-b724-c53346a0edb4"), Code="Assistant Professor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("ead700d3-b0d4-4f5e-ba6d-7aa887227e49"), Code="Instructor is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("04920224-7863-4d50-994a-913dc4ab0003"), Code="Lecturer is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=0 },
            new RefAcademicRank { Id=Guid.Parse("5ce783c6-e55a-43cd-8288-e04db008a910"), Code="No Academic Rank is specified as the academic rank of staff whose primary responsibility is instruction, research, and/or public service.", SortOrder=0 },
       };
   }
}
