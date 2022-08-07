//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefWageCollectionMethodList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefWageCollectionMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefWageCollectionMethodModel"> List
         /// </summary>
        public static List<RefWageCollectionMethodModel> RefWageCollectionMethodList = new List<RefWageCollectionMethodModel>
        {
            new RefWageCollectionMethod { Id=Guid.Parse("cf1b907b-3b01-42f3-b95c-eb3275867d2c"), Code="01", Description="Collected as an hourly wage amount", Definition="The wage data for an employment record was collected as an hourly wage amount.", SortOrder=Convert.ToDecimal("1.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("fe25ba3d-81b8-4a79-b452-3713ec3b06a0"), Code="02", Description="Collected as salary and converted to an hourly wage amount", Definition="The wage data for an employment record was collected as salary and converted to an hourly wage amount.", SortOrder=Convert.ToDecimal("2.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("a8df77fd-30bb-4aab-bdee-e1e7a84eb23a"), Code="03", Description="Collected in both methods but method not tracked on an individual record", Definition="The wage data for an employment record was collected in both methods but method not tracked on an individual record.", SortOrder=Convert.ToDecimal("3.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("c5a7da19-4583-47e2-a838-53ce2f14b69a"), Code="99", Description="Wage data not present", Definition="Wage data not present in the employment record.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefWageCollectionMethod Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefWageCollectionMethodViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefWageCollectionMethod { Id=Guid.Parse("cf1b907b-3b01-42f3-b95c-eb3275867d2c"), Description="Collected as an hourly wage amount", SortOrder=Convert.ToDecimal("1.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("fe25ba3d-81b8-4a79-b452-3713ec3b06a0"), Description="Collected as salary and converted to an hourly wage amount", SortOrder=Convert.ToDecimal("2.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("a8df77fd-30bb-4aab-bdee-e1e7a84eb23a"), Description="Collected in both methods but method not tracked on an individual record", SortOrder=Convert.ToDecimal("3.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("c5a7da19-4583-47e2-a838-53ce2f14b69a"), Description="Wage data not present", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
