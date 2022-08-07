//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityLeaseTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityLeaseType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityLeaseTypeModel"> List
         /// </summary>
        public static List<RefFacilityLeaseTypeModel> RefFacilityLeaseTypeList = new List<RefFacilityLeaseTypeModel>
        {
            new RefFacilityLeaseType { Id=Guid.Parse("bd20bc88-e199-4aef-b4b0-bc66b9c48907"), Code="13723", Description="Building lease", Definition="Building lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("12e9fd40-abb0-4886-8e8f-338e9ae0d01b"), Code="13724", Description="Ground lease", Definition="Ground lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("c40c4d5d-a4b8-4d8d-a6df-40c29154533e"), Code="13725", Description="Lease build to suit", Definition="Lease build to suit is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("e799d5d1-cf99-4318-a6df-027eaf1779e5"), Code="13726", Description="Lease shell with significant leasehold improvements", Definition="Lease shell with significant leasehold improvements is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("d5dd11c7-8ebe-4de2-8230-c2c13f3bf2b3"), Code="13727", Description="Triple-net lease", Definition="Triple-net lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefFacilityLeaseType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityLeaseTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityLeaseType { Id=Guid.Parse("bd20bc88-e199-4aef-b4b0-bc66b9c48907"), Description="Building lease", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("12e9fd40-abb0-4886-8e8f-338e9ae0d01b"), Description="Ground lease", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("c40c4d5d-a4b8-4d8d-a6df-40c29154533e"), Description="Lease build to suit", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("e799d5d1-cf99-4318-a6df-027eaf1779e5"), Description="Lease shell with significant leasehold improvements", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("d5dd11c7-8ebe-4de2-8230-c2c13f3bf2b3"), Description="Triple-net lease", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
