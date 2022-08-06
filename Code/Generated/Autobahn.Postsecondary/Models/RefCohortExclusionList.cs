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
        public static List<RefCohortExclusion> RefCohortExclusionList = new List<RefCohortExclusion> =
        {
            new RefCohortExclusion { Id=Guid.Parse("33cd3ea5-4b67-4187-bb8e-b4f924e53dbb"), Code="Death is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", Description="01", Definition="", SortOrder=0 },
            new RefCohortExclusion { Id=Guid.Parse("2aa4e25d-7c73-4a7e-b3fe-774f8884ea5e"), Code="Total and permanent disability is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", Description="02", Definition="", SortOrder=0 },
            new RefCohortExclusion { Id=Guid.Parse("ae7cd4af-a431-462a-b2ba-ef41a7640429"), Code="Service in the armed forces is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", Description="03", Definition="", SortOrder=0 },
            new RefCohortExclusion { Id=Guid.Parse("52103abd-1c07-4946-9045-4bb674d2ec48"), Code="Service with a foreign aid service of the federal government is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", Description="04", Definition="", SortOrder=0 },
            new RefCohortExclusion { Id=Guid.Parse("4dc8015e-2727-4140-964a-f1c0f8dfe480"), Code="Service on official church missions is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", Description="05", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCohortExclusion Pick List
         /// </summary>
        public static List<RefCohortExclusion> RefCohortExclusionPickList = new List<RefCohortExclusion> =
        {
            new RefCohortExclusion { Id=Guid.Parse("33cd3ea5-4b67-4187-bb8e-b4f924e53dbb"), Code="Death is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=0 },
            new RefCohortExclusion { Id=Guid.Parse("2aa4e25d-7c73-4a7e-b3fe-774f8884ea5e"), Code="Total and permanent disability is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=0 },
            new RefCohortExclusion { Id=Guid.Parse("ae7cd4af-a431-462a-b2ba-ef41a7640429"), Code="Service in the armed forces is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=0 },
            new RefCohortExclusion { Id=Guid.Parse("52103abd-1c07-4946-9045-4bb674d2ec48"), Code="Service with a foreign aid service of the federal government is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=0 },
            new RefCohortExclusion { Id=Guid.Parse("4dc8015e-2727-4140-964a-f1c0f8dfe480"), Code="Service on official church missions is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=0 },
       };
   }
}
