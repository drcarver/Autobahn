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
        /// The complete <see cref="RefCohortExclusionModel"> List
         /// </summary>
        public static List<RefCohortExclusionModel> RefCohortExclusionList = new List<RefCohortExclusionModel>
        {
            new RefCohortExclusion { Id=Guid.Parse("d0d477e8-1e11-448b-8032-94f0cb617e2b"), Code="01", Description="Death", Definition="Death is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("1.00") },
            new RefCohortExclusion { Id=Guid.Parse("7371e154-5250-4a22-9d45-28c29a8d5e47"), Code="02", Description="Total and permanent disability", Definition="Total and permanent disability is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("2.00") },
            new RefCohortExclusion { Id=Guid.Parse("c317c985-f24f-446c-a5bc-21c11c288eed"), Code="03", Description="Service in the armed forces", Definition="Service in the armed forces is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("3.00") },
            new RefCohortExclusion { Id=Guid.Parse("9108f57e-ab0c-427b-bc6e-226d08f023ef"), Code="04", Description="Service with a foreign aid service of the federal government", Definition="Service with a foreign aid service of the federal government is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("4.00") },
            new RefCohortExclusion { Id=Guid.Parse("b371fc1e-58d8-4a10-9215-beb1701e77cc"), Code="05", Description="Service on official church missions", Definition="Service on official church missions is specified as a reason for a person to be removed (deleted) from a cohort (or subcohort).", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefCohortExclusion Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCohortExclusionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCohortExclusion { Id=Guid.Parse("d0d477e8-1e11-448b-8032-94f0cb617e2b"), Description="Death", SortOrder=Convert.ToDecimal("1.00") },
            new RefCohortExclusion { Id=Guid.Parse("7371e154-5250-4a22-9d45-28c29a8d5e47"), Description="Total and permanent disability", SortOrder=Convert.ToDecimal("2.00") },
            new RefCohortExclusion { Id=Guid.Parse("c317c985-f24f-446c-a5bc-21c11c288eed"), Description="Service in the armed forces", SortOrder=Convert.ToDecimal("3.00") },
            new RefCohortExclusion { Id=Guid.Parse("9108f57e-ab0c-427b-bc6e-226d08f023ef"), Description="Service with a foreign aid service of the federal government", SortOrder=Convert.ToDecimal("4.00") },
            new RefCohortExclusion { Id=Guid.Parse("b371fc1e-58d8-4a10-9215-beb1701e77cc"), Description="Service on official church missions", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
