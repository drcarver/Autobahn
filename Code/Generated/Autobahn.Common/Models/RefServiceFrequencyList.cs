//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefServiceFrequencyList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefServiceFrequency Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefServiceFrequency"> List
         /// </summary>
        public static List<RefServiceFrequency> RefServiceFrequencyList = new List<RefServiceFrequency>
        {
            new RefServiceFrequency { Id=Guid.Parse("986c56ca-4ab4-4c00-a65e-46752ae01356"), Code="Daily", Description="Daily", Definition="The service is planned to be provided Daily.", SortOrder=Convert.ToDecimal("2.00") },
            new RefServiceFrequency { Id=Guid.Parse("2309e032-3e89-4f2d-a50d-da22f9597218"), Code="Weekly", Description="Weekly", Definition="The service is planned to be provided Weekly.", SortOrder=Convert.ToDecimal("4.00") },
            new RefServiceFrequency { Id=Guid.Parse("d1c7635d-5eb7-4ec4-9155-e14bc1e7f789"), Code="Biweekly", Description="Biweekly", Definition="The service is planned to be provided Biweekly.", SortOrder=Convert.ToDecimal("6.00") },
            new RefServiceFrequency { Id=Guid.Parse("943e96a1-ca8c-41d4-b929-3f5cafd2184f"), Code="Monthly", Description="Monthly", Definition="The service is planned to be provided Monthly.", SortOrder=Convert.ToDecimal("8.00") },
            new RefServiceFrequency { Id=Guid.Parse("fd023f09-8337-4135-8630-add830d7f1f7"), Code="Bimonthly", Description="Bimonthly", Definition="The service is planned to be provided Bimonthly.", SortOrder=Convert.ToDecimal("10.00") },
            new RefServiceFrequency { Id=Guid.Parse("99e826ff-867a-4d54-bac5-1810596c8fef"), Code="Quarterly", Description="Quarterly", Definition="The service is planned to be provided Quarterly.", SortOrder=Convert.ToDecimal("12.00") },
            new RefServiceFrequency { Id=Guid.Parse("aefde06a-1672-4e5c-8878-365e9cf596a1"), Code="Semiannually", Description="Semiannually", Definition="The service is planned to be provided Semiannually.", SortOrder=Convert.ToDecimal("14.00") },
            new RefServiceFrequency { Id=Guid.Parse("038eeb02-8c9e-44c1-99e1-975ce93c7eab"), Code="Annually", Description="Annually", Definition="The service is planned to be provided Annually.", SortOrder=Convert.ToDecimal("16.00") },
            new RefServiceFrequency { Id=Guid.Parse("8b8652a3-a061-4b78-9da9-ea6c9b2a9eba"), Code="Other", Description="Other", Definition="The service is planned to be provided at a frequency not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefServiceFrequency Pick List
         /// </summary>
        public static List<RefServiceFrequency> RefServiceFrequencyPickList = new List<RefServiceFrequency>
        {
            new RefServiceFrequency { Id=Guid.Parse("986c56ca-4ab4-4c00-a65e-46752ae01356"), Code="Daily", Description="Daily", SortOrder=Convert.ToDecimal("2.00") },
            new RefServiceFrequency { Id=Guid.Parse("2309e032-3e89-4f2d-a50d-da22f9597218"), Code="Weekly", Description="Weekly", SortOrder=Convert.ToDecimal("4.00") },
            new RefServiceFrequency { Id=Guid.Parse("d1c7635d-5eb7-4ec4-9155-e14bc1e7f789"), Code="Biweekly", Description="Biweekly", SortOrder=Convert.ToDecimal("6.00") },
            new RefServiceFrequency { Id=Guid.Parse("943e96a1-ca8c-41d4-b929-3f5cafd2184f"), Code="Monthly", Description="Monthly", SortOrder=Convert.ToDecimal("8.00") },
            new RefServiceFrequency { Id=Guid.Parse("fd023f09-8337-4135-8630-add830d7f1f7"), Code="Bimonthly", Description="Bimonthly", SortOrder=Convert.ToDecimal("10.00") },
            new RefServiceFrequency { Id=Guid.Parse("99e826ff-867a-4d54-bac5-1810596c8fef"), Code="Quarterly", Description="Quarterly", SortOrder=Convert.ToDecimal("12.00") },
            new RefServiceFrequency { Id=Guid.Parse("aefde06a-1672-4e5c-8878-365e9cf596a1"), Code="Semiannually", Description="Semiannually", SortOrder=Convert.ToDecimal("14.00") },
            new RefServiceFrequency { Id=Guid.Parse("038eeb02-8c9e-44c1-99e1-975ce93c7eab"), Code="Annually", Description="Annually", SortOrder=Convert.ToDecimal("16.00") },
            new RefServiceFrequency { Id=Guid.Parse("8b8652a3-a061-4b78-9da9-ea6c9b2a9eba"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
