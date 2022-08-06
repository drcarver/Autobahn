//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCohortExclusionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCohortExclusion Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCohortExclusion"> List
         /// </summary>
        public static List<RefCohortExclusion> RefCohortExclusionList = new List<RefCohortExclusion>
        {
            new RefCohortExclusion { Id=Guid.Parse("c6210e21-1cb8-4603-b1f4-a807153bd893"), Code="01", Description="Death", Definition="Death is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("1.00") },
            new RefCohortExclusion { Id=Guid.Parse("2c574e37-c39a-462a-8ce3-7c6aeb2d2468"), Code="02", Description="Total and permanent disability", Definition="Total and permanent disability is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("2.00") },
            new RefCohortExclusion { Id=Guid.Parse("6abd0406-520c-4388-aaa4-da5d1077b041"), Code="03", Description="Service in the armed forces", Definition="Service in the armed forces is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("3.00") },
            new RefCohortExclusion { Id=Guid.Parse("3c91c2b5-019d-4e66-9361-75826c370b3d"), Code="04", Description="Service with a foreign aid service of the federal government", Definition="Service with a foreign aid service of the federal government is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("4.00") },
            new RefCohortExclusion { Id=Guid.Parse("b389344e-509c-4aa7-9d98-35f878b4604c"), Code="05", Description="Service on official church missions", Definition="Service on official church missions is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefCohortExclusion Pick List
         /// </summary>
        public static List<RefCohortExclusion> RefCohortExclusionPickList = new List<RefCohortExclusion>
        {
            new RefCohortExclusion { Id=Guid.Parse("c6210e21-1cb8-4603-b1f4-a807153bd893"), Code="01", Description="Death", SortOrder=Convert.ToDecimal("1.00") },
            new RefCohortExclusion { Id=Guid.Parse("2c574e37-c39a-462a-8ce3-7c6aeb2d2468"), Code="02", Description="Total and permanent disability", SortOrder=Convert.ToDecimal("2.00") },
            new RefCohortExclusion { Id=Guid.Parse("6abd0406-520c-4388-aaa4-da5d1077b041"), Code="03", Description="Service in the armed forces", SortOrder=Convert.ToDecimal("3.00") },
            new RefCohortExclusion { Id=Guid.Parse("3c91c2b5-019d-4e66-9361-75826c370b3d"), Code="04", Description="Service with a foreign aid service of the federal government", SortOrder=Convert.ToDecimal("4.00") },
            new RefCohortExclusion { Id=Guid.Parse("b389344e-509c-4aa7-9d98-35f878b4604c"), Code="05", Description="Service on official church missions", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
