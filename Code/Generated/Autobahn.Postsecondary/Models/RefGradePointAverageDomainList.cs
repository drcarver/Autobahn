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
        public static List<RefGradePointAverageDomain> RefGradePointAverageDomainList = new List<RefGradePointAverageDomain>
        {
            new RefGradePointAverageDomain { Id=Guid.Parse("12fdaf4b-2b2b-42d7-a823-2d7238d8a090"), Code="HighSchool", Description="High School", Definition="High School is the domain to which the Grade Point Average is referencing.", SortOrder=Convert.ToDecimal("1.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("03d70116-3d69-4186-8a30-8cf5b8129684"), Code="PSUndergraduate", Description="Postsecondary Undergraduate", Definition="Postsecondary Undergraduate is the domain to which the Grade Point Average is referencing.", SortOrder=Convert.ToDecimal("2.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("cb035581-3f3e-4ada-a9e9-1bd1b8d9918c"), Code="PSTransfer", Description="Postsecondary Transfer Institution", Definition="Postsecondary Transfer Institution is the domain to which the Grade Point Average is referencing.", SortOrder=Convert.ToDecimal("3.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("c620f733-b42f-4147-bca6-e865cced597f"), Code="PSGraduate", Description="Postsecondary Graduate", Definition="Postsecondary Graduate is the domain to which the Grade Point Average is referencing.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefGradePointAverageDomain Pick List
         /// </summary>
        public static List<RefGradePointAverageDomain> RefGradePointAverageDomainPickList = new List<RefGradePointAverageDomain>
        {
            new RefGradePointAverageDomain { Id=Guid.Parse("12fdaf4b-2b2b-42d7-a823-2d7238d8a090"), Code="HighSchool", Description="High School", SortOrder=Convert.ToDecimal("1.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("03d70116-3d69-4186-8a30-8cf5b8129684"), Code="PSUndergraduate", Description="Postsecondary Undergraduate", SortOrder=Convert.ToDecimal("2.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("cb035581-3f3e-4ada-a9e9-1bd1b8d9918c"), Code="PSTransfer", Description="Postsecondary Transfer Institution", SortOrder=Convert.ToDecimal("3.00") },
            new RefGradePointAverageDomain { Id=Guid.Parse("c620f733-b42f-4147-bca6-e865cced597f"), Code="PSGraduate", Description="Postsecondary Graduate", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
