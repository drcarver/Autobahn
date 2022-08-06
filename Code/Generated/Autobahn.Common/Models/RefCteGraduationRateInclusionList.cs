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
        public static List<RefCteGraduationRateInclusion> RefCteGraduationRateInclusionList = new List<RefCteGraduationRateInclusion>
        {
            new RefCteGraduationRateInclusion { Id=Guid.Parse("4d82ca07-7b9b-4134-a0bf-4c321ca58c53"), Code="IncludedAsGraduated", Description="Included in computation as graduated  ", Definition="CTE concentrators are included in the state's computation of its graduation rate as graduated.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCteGraduationRateInclusion { Id=Guid.Parse("fe46de28-907a-4b7a-a0f3-4c20066e66ca"), Code="NotIncludedAsGraduated", Description="Included in computation as not graduated.", Definition="CTE concentrators are included in the state's computation of its graduation rate as not graduated.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefCteGraduationRateInclusion Pick List
         /// </summary>
        public static List<RefCteGraduationRateInclusion> RefCteGraduationRateInclusionPickList = new List<RefCteGraduationRateInclusion>
        {
            new RefCteGraduationRateInclusion { Id=Guid.Parse("4d82ca07-7b9b-4134-a0bf-4c321ca58c53"), Code="IncludedAsGraduated", Description="Included in computation as graduated  ", SortOrder=Convert.ToDecimal("1.00") },
            new RefCteGraduationRateInclusion { Id=Guid.Parse("fe46de28-907a-4b7a-a0f3-4c20066e66ca"), Code="NotIncludedAsGraduated", Description="Included in computation as not graduated.", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
