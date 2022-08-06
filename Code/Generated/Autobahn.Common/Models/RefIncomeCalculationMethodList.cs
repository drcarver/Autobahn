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
        public static List<RefIncomeCalculationMethod> RefIncomeCalculationMethodList = new List<RefIncomeCalculationMethod> =
        {
            new RefIncomeCalculationMethod { Id=Guid.Parse("9f46bc7f-21d8-4f6b-a252-d2e8d514a4db"), Code="Head Start is the calculation method used by a program to determine total family income.", Description="HeadStart", Definition="", SortOrder=0 },
            new RefIncomeCalculationMethod { Id=Guid.Parse("9447cdcb-8090-4562-ae7a-69b1ad88109f"), Code="State-specific calculation is the calculation method used by a program to determine total family income.", Description="StateSpecific", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIncomeCalculationMethod Pick List
         /// </summary>
        public static List<RefIncomeCalculationMethod> RefIncomeCalculationMethodPickList = new List<RefIncomeCalculationMethod> =
        {
            new RefIncomeCalculationMethod { Id=Guid.Parse("9f46bc7f-21d8-4f6b-a252-d2e8d514a4db"), Code="Head Start is the calculation method used by a program to determine total family income.", SortOrder=0 },
            new RefIncomeCalculationMethod { Id=Guid.Parse("9447cdcb-8090-4562-ae7a-69b1ad88109f"), Code="State-specific calculation is the calculation method used by a program to determine total family income.", SortOrder=0 },
       };
   }
}
