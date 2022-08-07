//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncomeCalculationMethodList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncomeCalculationMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncomeCalculationMethodModel"> List
         /// </summary>
        public static List<RefIncomeCalculationMethodModel> RefIncomeCalculationMethodList = new List<RefIncomeCalculationMethodModel>
        {
            new RefIncomeCalculationMethod { Id=Guid.Parse("5c8b25b6-c4e7-49ee-8d3b-b7f1c54dbc11"), Code="HeadStart", Description="Head Start calculation", Definition="Head Start is the calculation method used by a program to determine total family income.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncomeCalculationMethod { Id=Guid.Parse("8ad29958-d061-4434-98b2-eeb9e5024aca"), Code="StateSpecific", Description="State-specific calculation", Definition="State-specific calculation is the calculation method used by a program to determine total family income.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefIncomeCalculationMethod Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIncomeCalculationMethodViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIncomeCalculationMethod { Id=Guid.Parse("5c8b25b6-c4e7-49ee-8d3b-b7f1c54dbc11"), Description="Head Start calculation", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncomeCalculationMethod { Id=Guid.Parse("8ad29958-d061-4434-98b2-eeb9e5024aca"), Description="State-specific calculation", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
