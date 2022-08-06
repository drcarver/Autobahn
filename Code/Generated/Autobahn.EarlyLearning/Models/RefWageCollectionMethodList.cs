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
        /// The complete <see cref="RefWageCollectionMethod"> List
         /// </summary>
        public static List<RefWageCollectionMethod> RefWageCollectionMethodList = new List<RefWageCollectionMethod>
        {
            new RefWageCollectionMethod { Id=Guid.Parse("9a8bfa31-a68b-423e-9031-eff220064f3d"), Code="01", Description="Collected as an hourly wage amount", Definition="The wage data for an employment record was collected as an hourly wage amount.", SortOrder=Convert.ToDecimal("1.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("94372c80-8a33-4a0e-818a-8d888b62715c"), Code="02", Description="Collected as salary and converted to an hourly wage amount", Definition="The wage data for an employment record was collected as salary and converted to an hourly wage amount.", SortOrder=Convert.ToDecimal("2.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("c5faead7-14d8-42db-8e37-84f9986e8050"), Code="03", Description="Collected in both methods but method not tracked on an individual record", Definition="The wage data for an employment record was collected in both methods but method not tracked on an individual record.", SortOrder=Convert.ToDecimal("3.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("7b46d7d5-1136-44a5-bb02-a5092a4323aa"), Code="99", Description="Wage data not present", Definition="Wage data not present in the employment record.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefWageCollectionMethod Pick List
         /// </summary>
        public static List<RefWageCollectionMethod> RefWageCollectionMethodPickList = new List<RefWageCollectionMethod>
        {
            new RefWageCollectionMethod { Id=Guid.Parse("9a8bfa31-a68b-423e-9031-eff220064f3d"), Code="01", Description="Collected as an hourly wage amount", SortOrder=Convert.ToDecimal("1.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("94372c80-8a33-4a0e-818a-8d888b62715c"), Code="02", Description="Collected as salary and converted to an hourly wage amount", SortOrder=Convert.ToDecimal("2.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("c5faead7-14d8-42db-8e37-84f9986e8050"), Code="03", Description="Collected in both methods but method not tracked on an individual record", SortOrder=Convert.ToDecimal("3.00") },
            new RefWageCollectionMethod { Id=Guid.Parse("7b46d7d5-1136-44a5-bb02-a5092a4323aa"), Code="99", Description="Wage data not present", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
