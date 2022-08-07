//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGpaWeightedIndicatorList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefGpaWeightedIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGpaWeightedIndicatorModel"> List
         /// </summary>
        public static List<RefGpaWeightedIndicatorModel> RefGpaWeightedIndicatorList = new List<RefGpaWeightedIndicatorModel>
        {
            new RefGpaWeightedIndicator { Id=Guid.Parse("11bd0d6c-33fb-4adc-bf42-760faa0094d4"), Code="Weighted", Description="Weighted", Definition="The reported Grade Point Average is weighted.", SortOrder=Convert.ToDecimal("1.00") },
            new RefGpaWeightedIndicator { Id=Guid.Parse("ca47b72b-d6bd-4c2c-87ba-c1542dc52119"), Code="Unweighted", Description="Unweighted", Definition="The reported Grade Point Average is unweighted.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefGpaWeightedIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefGpaWeightedIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefGpaWeightedIndicator { Id=Guid.Parse("11bd0d6c-33fb-4adc-bf42-760faa0094d4"), Description="Weighted", SortOrder=Convert.ToDecimal("1.00") },
            new RefGpaWeightedIndicator { Id=Guid.Parse("ca47b72b-d6bd-4c2c-87ba-c1542dc52119"), Description="Unweighted", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
