//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCteGraduationRateInclusionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCteGraduationRateInclusion Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCteGraduationRateInclusion"> List
         /// </summary>
        public static List<RefCteGraduationRateInclusion> RefCteGraduationRateInclusionList = new List<RefCteGraduationRateInclusion> =
        {
            new RefCteGraduationRateInclusion { Id=Guid.Parse("611775cb-9a5c-425c-b35f-1d9c9737290e"), Code="CTE concentrators are included in the state's computation of its graduation rate as graduated.", Description="IncludedAsGraduated", Definition="", SortOrder=0 },
            new RefCteGraduationRateInclusion { Id=Guid.Parse("a9ba7ab1-7923-422e-8e57-1a1deaa1fea2"), Code="CTE concentrators are included in the state's computation of its graduation rate as not graduated.", Description="NotIncludedAsGraduated", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCteGraduationRateInclusion Pick List
         /// </summary>
        public static List<RefCteGraduationRateInclusion> RefCteGraduationRateInclusionPickList = new List<RefCteGraduationRateInclusion> =
        {
            new RefCteGraduationRateInclusion { Id=Guid.Parse("611775cb-9a5c-425c-b35f-1d9c9737290e"), Code="CTE concentrators are included in the state's computation of its graduation rate as graduated.", SortOrder=0 },
            new RefCteGraduationRateInclusion { Id=Guid.Parse("a9ba7ab1-7923-422e-8e57-1a1deaa1fea2"), Code="CTE concentrators are included in the state's computation of its graduation rate as not graduated.", SortOrder=0 },
       };
   }
}
