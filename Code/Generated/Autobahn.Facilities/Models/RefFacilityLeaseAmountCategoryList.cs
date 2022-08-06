//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityLeaseAmountCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityLeaseAmountCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityLeaseAmountCategory"> List
         /// </summary>
        public static List<RefFacilityLeaseAmountCategory> RefFacilityLeaseAmountCategoryList = new List<RefFacilityLeaseAmountCategory> =
        {
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("010a8748-a599-48a6-b9ef-174bde6f3bfb"), Code="Base rent is specified as the category of payment that a school must pay to rent the facility that it is in.", Description="13720", Definition="", SortOrder=0 },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("2ee0c763-2f64-47bc-93fc-0c93eecde2b8"), Code="Credit is specified as the category of payment that a school must pay to rent the facility that it is in.", Description="13721", Definition="", SortOrder=0 },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("eb4b1b0b-4b56-4f33-a7ad-ab21e807585a"), Code="Escalator is specified as the category of payment that a school must pay to rent the facility that it is in.", Description="13722", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityLeaseAmountCategory Pick List
         /// </summary>
        public static List<RefFacilityLeaseAmountCategory> RefFacilityLeaseAmountCategoryPickList = new List<RefFacilityLeaseAmountCategory> =
        {
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("010a8748-a599-48a6-b9ef-174bde6f3bfb"), Code="Base rent is specified as the category of payment that a school must pay to rent the facility that it is in.", SortOrder=0 },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("2ee0c763-2f64-47bc-93fc-0c93eecde2b8"), Code="Credit is specified as the category of payment that a school must pay to rent the facility that it is in.", SortOrder=0 },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("eb4b1b0b-4b56-4f33-a7ad-ab21e807585a"), Code="Escalator is specified as the category of payment that a school must pay to rent the facility that it is in.", SortOrder=0 },
       };
   }
}
