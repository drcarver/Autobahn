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
        public static List<RefFacilityMortgageType> RefFacilityMortgageTypeList = new List<RefFacilityMortgageType> =
        {
            new RefFacilityMortgageType { Id=Guid.Parse("dd1c7758-a431-482b-b62f-1f85ee91e274"), Code="Any mortgage on a property that is subordinate to a senior mortgage in priority. Also called subordinated mortgage.", Description="13741", Definition="", SortOrder=0 },
            new RefFacilityMortgageType { Id=Guid.Parse("4e274067-6e0b-4247-8eda-f07bd95cc537"), Code="A property may have multiple mortgages on it. Second mortgages are subordinate, meaning that in the event of default, the primary, or first mortgage would get paid off first, and then any funds remaining would be used to pay off any second mortgages.", Description="13742", Definition="", SortOrder=0 },
            new RefFacilityMortgageType { Id=Guid.Parse("7de26b0d-0b48-4cfc-8839-9ad0dbf8555e"), Code="The mortgage that has first claim in the event of a default. The first or senior mortgage typically has to be satisfied before the second or junior mortgage can enforce any claims against the property.", Description="13743", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityMortgageType Pick List
         /// </summary>
        public static List<RefFacilityMortgageType> RefFacilityMortgageTypePickList = new List<RefFacilityMortgageType> =
        {
            new RefFacilityMortgageType { Id=Guid.Parse("dd1c7758-a431-482b-b62f-1f85ee91e274"), Code="Any mortgage on a property that is subordinate to a senior mortgage in priority. Also called subordinated mortgage.", SortOrder=0 },
            new RefFacilityMortgageType { Id=Guid.Parse("4e274067-6e0b-4247-8eda-f07bd95cc537"), Code="A property may have multiple mortgages on it. Second mortgages are subordinate, meaning that in the event of default, the primary, or first mortgage would get paid off first, and then any funds remaining would be used to pay off any second mortgages.", SortOrder=0 },
            new RefFacilityMortgageType { Id=Guid.Parse("7de26b0d-0b48-4cfc-8839-9ad0dbf8555e"), Code="The mortgage that has first claim in the event of a default. The first or senior mortgage typically has to be satisfied before the second or junior mortgage can enforce any claims against the property.", SortOrder=0 },
       };
   }
}
