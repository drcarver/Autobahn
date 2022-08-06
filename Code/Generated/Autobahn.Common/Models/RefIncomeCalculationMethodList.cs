//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncomeCalculationMethodList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncomeCalculationMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncomeCalculationMethod"> List
         /// </summary>
        public static List<RefIncomeCalculationMethod> RefIncomeCalculationMethodList = new List<RefIncomeCalculationMethod>
        {
            new RefIncomeCalculationMethod { Id=Guid.Parse("287c0064-0044-425f-88de-06fa14d65ee7"), Code="HeadStart", Description="Head Start calculation", Definition="Head Start is the calculation method used by a program to determine total family income.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncomeCalculationMethod { Id=Guid.Parse("a53b7fad-2d3b-4853-a922-ff905748ec1c"), Code="StateSpecific", Description="State-specific calculation", Definition="State-specific calculation is the calculation method used by a program to determine total family income.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefIncomeCalculationMethod Pick List
         /// </summary>
        public static List<RefIncomeCalculationMethod> RefIncomeCalculationMethodPickList = new List<RefIncomeCalculationMethod>
        {
            new RefIncomeCalculationMethod { Id=Guid.Parse("287c0064-0044-425f-88de-06fa14d65ee7"), Code="HeadStart", Description="Head Start calculation", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncomeCalculationMethod { Id=Guid.Parse("a53b7fad-2d3b-4853-a922-ff905748ec1c"), Code="StateSpecific", Description="State-specific calculation", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
