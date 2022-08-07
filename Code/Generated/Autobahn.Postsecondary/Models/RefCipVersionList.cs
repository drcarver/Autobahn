//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCipVersionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCipVersion Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCipVersionModel"> List
         /// </summary>
        public static List<RefCipVersionModel> RefCipVersionList = new List<RefCipVersionModel>
        {
            new RefCipVersion { Id=Guid.Parse("72e10c77-cfc2-4cb4-acb5-04750117ac24"), Code="CIP1980", Description="CIP 1980", Definition="CIP 1980 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCipVersion { Id=Guid.Parse("4d1b230e-87e6-468e-b3cb-0f592ce1a9dc"), Code="CIP1985", Description="CIP 1985", Definition="CIP 1985 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCipVersion { Id=Guid.Parse("eb750a60-79b4-4086-ad61-01db34b19e5f"), Code="CIP1990", Description="CIP 1990", Definition="CIP 1990 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCipVersion { Id=Guid.Parse("d59ebad5-e251-4a45-9a60-5503f428c41b"), Code="CIP2000", Description="CIP 2000", Definition="CIP 2000 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCipVersion { Id=Guid.Parse("73ef7476-a54c-4140-aa0a-7eaac20375f8"), Code="CIP2010", Description="CIP 2010", Definition="CIP 2010 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefCipVersion Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCipVersionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCipVersion { Id=Guid.Parse("72e10c77-cfc2-4cb4-acb5-04750117ac24"), Description="CIP 1980", SortOrder=Convert.ToDecimal("1.00") },
            new RefCipVersion { Id=Guid.Parse("4d1b230e-87e6-468e-b3cb-0f592ce1a9dc"), Description="CIP 1985", SortOrder=Convert.ToDecimal("2.00") },
            new RefCipVersion { Id=Guid.Parse("eb750a60-79b4-4086-ad61-01db34b19e5f"), Description="CIP 1990", SortOrder=Convert.ToDecimal("3.00") },
            new RefCipVersion { Id=Guid.Parse("d59ebad5-e251-4a45-9a60-5503f428c41b"), Description="CIP 2000", SortOrder=Convert.ToDecimal("4.00") },
            new RefCipVersion { Id=Guid.Parse("73ef7476-a54c-4140-aa0a-7eaac20375f8"), Description="CIP 2010", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
