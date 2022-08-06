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
        public static List<RefWageCollectionMethod> RefWageCollectionMethodList = new List<RefWageCollectionMethod> =
        {
            new RefWageCollectionMethod { Id=Guid.Parse("4cfc1024-7941-42db-8226-2d89bb966f7e"), Code="The wage data for an employment record was collected as an hourly wage amount.", Description="01", Definition="", SortOrder=0 },
            new RefWageCollectionMethod { Id=Guid.Parse("7b67656f-d967-4a40-ac8f-b1567846961b"), Code="The wage data for an employment record was collected as salary and converted to an hourly wage amount.", Description="02", Definition="", SortOrder=0 },
            new RefWageCollectionMethod { Id=Guid.Parse("db295d39-db6f-4206-8b14-b8b4b2bb197e"), Code="The wage data for an employment record was collected in both methods but method not tracked on an individual record.", Description="03", Definition="", SortOrder=0 },
            new RefWageCollectionMethod { Id=Guid.Parse("cad9896b-5264-4751-9e86-d7586ba6e89c"), Code="Wage data not present in the employment record.", Description="99", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefWageCollectionMethod Pick List
         /// </summary>
        public static List<RefWageCollectionMethod> RefWageCollectionMethodPickList = new List<RefWageCollectionMethod> =
        {
            new RefWageCollectionMethod { Id=Guid.Parse("4cfc1024-7941-42db-8226-2d89bb966f7e"), Code="The wage data for an employment record was collected as an hourly wage amount.", SortOrder=0 },
            new RefWageCollectionMethod { Id=Guid.Parse("7b67656f-d967-4a40-ac8f-b1567846961b"), Code="The wage data for an employment record was collected as salary and converted to an hourly wage amount.", SortOrder=0 },
            new RefWageCollectionMethod { Id=Guid.Parse("db295d39-db6f-4206-8b14-b8b4b2bb197e"), Code="The wage data for an employment record was collected in both methods but method not tracked on an individual record.", SortOrder=0 },
            new RefWageCollectionMethod { Id=Guid.Parse("cad9896b-5264-4751-9e86-d7586ba6e89c"), Code="Wage data not present in the employment record.", SortOrder=0 },
       };
   }
}
