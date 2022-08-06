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
        public static List<RefFacilityLeaseAmountCategory> RefFacilityLeaseAmountCategoryList = new List<RefFacilityLeaseAmountCategory>
        {
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("8c8a22cb-4f69-407d-89f0-ddc6635493e5"), Code="13720", Description="Base rent", Definition="Base rent is specified as the category of payment that a school must pay to rent the facility that it is in.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("8103e2e6-fb38-4b9a-b34d-f14d47cd3d29"), Code="13721", Description="Credit", Definition="Credit is specified as the category of payment that a school must pay to rent the facility that it is in.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("ddfa767b-93a1-4117-8618-e3b442580e4b"), Code="13722", Description="Escalator", Definition="Escalator is specified as the category of payment that a school must pay to rent the facility that it is in.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefFacilityLeaseAmountCategory Pick List
         /// </summary>
        public static List<RefFacilityLeaseAmountCategory> RefFacilityLeaseAmountCategoryPickList = new List<RefFacilityLeaseAmountCategory>
        {
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("8c8a22cb-4f69-407d-89f0-ddc6635493e5"), Code="13720", Description="Base rent", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("8103e2e6-fb38-4b9a-b34d-f14d47cd3d29"), Code="13721", Description="Credit", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("ddfa767b-93a1-4117-8618-e3b442580e4b"), Code="13722", Description="Escalator", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
