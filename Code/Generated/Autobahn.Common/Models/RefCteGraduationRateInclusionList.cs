//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCteGraduationRateInclusionList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCteGraduationRateInclusion Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCteGraduationRateInclusionModel"> List
         /// </summary>
        public static List<RefCteGraduationRateInclusionModel> RefCteGraduationRateInclusionList = new List<RefCteGraduationRateInclusionModel>
        {
            new RefCteGraduationRateInclusion { Id=Guid.Parse("751903f2-cb9c-4d03-98cb-059adb97738b"), Code="IncludedAsGraduated", Description="Included in computation as graduated  ", Definition="CTE concentrators are included in the state's computation of its graduation rate as graduated.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCteGraduationRateInclusion { Id=Guid.Parse("056aef72-b15e-4847-819e-303d027f5f06"), Code="NotIncludedAsGraduated", Description="Included in computation as not graduated.", Definition="CTE concentrators are included in the state's computation of its graduation rate as not graduated.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefCteGraduationRateInclusion Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCteGraduationRateInclusionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCteGraduationRateInclusion { Id=Guid.Parse("751903f2-cb9c-4d03-98cb-059adb97738b"), Description="Included in computation as graduated  ", SortOrder=Convert.ToDecimal("1.00") },
            new RefCteGraduationRateInclusion { Id=Guid.Parse("056aef72-b15e-4847-819e-303d027f5f06"), Description="Included in computation as not graduated.", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
