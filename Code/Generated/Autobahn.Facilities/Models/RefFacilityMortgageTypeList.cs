//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityMortgageTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityMortgageType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityMortgageType"> List
         /// </summary>
        public static List<RefFacilityMortgageType> RefFacilityMortgageTypeList = new List<RefFacilityMortgageType>
        {
            new RefFacilityMortgageType { Id=Guid.Parse("0143bdb3-e53e-4147-84a3-41f730f80869"), Code="13741", Description="Junior Mortgage", Definition="Any mortgage on a property that is subordinate to a senior mortgage in priority. Also called subordinated mortgage.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMortgageType { Id=Guid.Parse("aebb4699-3518-45bd-b945-b0063b4f9dcb"), Code="13742", Description="Multiple", Definition="A property may have multiple mortgages on it. Second mortgages are subordinate, meaning that in the event of default, the primary, or first mortgage would get paid off first, and then any funds remaining would be used to pay off any second mortgages.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMortgageType { Id=Guid.Parse("4ade0e0a-9035-4585-b55d-5e7343c2d42c"), Code="13743", Description="Senior or first mortgage", Definition="The mortgage that has first claim in the event of a default. The first or senior mortgage typically has to be satisfied before the second or junior mortgage can enforce any claims against the property.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefFacilityMortgageType Pick List
         /// </summary>
        public static List<RefFacilityMortgageType> RefFacilityMortgageTypePickList = new List<RefFacilityMortgageType>
        {
            new RefFacilityMortgageType { Id=Guid.Parse("0143bdb3-e53e-4147-84a3-41f730f80869"), Code="13741", Description="Junior Mortgage", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMortgageType { Id=Guid.Parse("aebb4699-3518-45bd-b945-b0063b4f9dcb"), Code="13742", Description="Multiple", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMortgageType { Id=Guid.Parse("4ade0e0a-9035-4585-b55d-5e7343c2d42c"), Code="13743", Description="Senior or first mortgage", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
