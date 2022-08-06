//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefGradePointAverageDomainList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefGradePointAverageDomain Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGradePointAverageDomain"> List
         /// </summary>
        public static List<RefGradePointAverageDomain> RefGradePointAverageDomainList = new List<RefGradePointAverageDomain> =
        {
            new RefGradePointAverageDomain { Id=Guid.Parse("b40dfcaf-e229-48b4-8be8-1c207df42c3c"), Code="High School is the domain to which the Grade Point Average is referencing.", Description="HighSchool", Definition="", SortOrder=0 },
            new RefGradePointAverageDomain { Id=Guid.Parse("99e71ba7-1836-4033-99aa-956a302ae948"), Code="Postsecondary Undergraduate is the domain to which the Grade Point Average is referencing.", Description="PSUndergraduate", Definition="", SortOrder=0 },
            new RefGradePointAverageDomain { Id=Guid.Parse("972deabe-8ac5-4bda-ac97-e123e7a91216"), Code="Postsecondary Transfer Institution is the domain to which the Grade Point Average is referencing.", Description="PSTransfer", Definition="", SortOrder=0 },
            new RefGradePointAverageDomain { Id=Guid.Parse("90df2b0f-696c-49b4-91ca-15fd26f5b992"), Code="Postsecondary Graduate is the domain to which the Grade Point Average is referencing.", Description="PSGraduate", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefGradePointAverageDomain Pick List
         /// </summary>
        public static List<RefGradePointAverageDomain> RefGradePointAverageDomainPickList = new List<RefGradePointAverageDomain> =
        {
            new RefGradePointAverageDomain { Id=Guid.Parse("b40dfcaf-e229-48b4-8be8-1c207df42c3c"), Code="High School is the domain to which the Grade Point Average is referencing.", SortOrder=0 },
            new RefGradePointAverageDomain { Id=Guid.Parse("99e71ba7-1836-4033-99aa-956a302ae948"), Code="Postsecondary Undergraduate is the domain to which the Grade Point Average is referencing.", SortOrder=0 },
            new RefGradePointAverageDomain { Id=Guid.Parse("972deabe-8ac5-4bda-ac97-e123e7a91216"), Code="Postsecondary Transfer Institution is the domain to which the Grade Point Average is referencing.", SortOrder=0 },
            new RefGradePointAverageDomain { Id=Guid.Parse("90df2b0f-696c-49b4-91ca-15fd26f5b992"), Code="Postsecondary Graduate is the domain to which the Grade Point Average is referencing.", SortOrder=0 },
       };
   }
}
