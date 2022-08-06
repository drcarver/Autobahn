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
        /// The complete <see cref="RefFacilityLeaseType"> List
         /// </summary>
        public static List<RefFacilityLeaseType> RefFacilityLeaseTypeList = new List<RefFacilityLeaseType> =
        {
            new RefFacilityLeaseType { Id=Guid.Parse("6fde4127-c689-4dc5-95e1-4646d49ce654"), Code="Building lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", Description="13723", Definition="", SortOrder=0 },
            new RefFacilityLeaseType { Id=Guid.Parse("5908d67b-f6a8-485f-9bd3-e8cd50963241"), Code="Ground lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", Description="13724", Definition="", SortOrder=0 },
            new RefFacilityLeaseType { Id=Guid.Parse("50f9cb17-828c-49ff-b2c2-253fe86a5e0f"), Code="Lease build to suit is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", Description="13725", Definition="", SortOrder=0 },
            new RefFacilityLeaseType { Id=Guid.Parse("e37c8a07-6fda-4f90-ae92-57d2a4bdc429"), Code="Lease shell with significant leasehold improvements is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", Description="13726", Definition="", SortOrder=0 },
            new RefFacilityLeaseType { Id=Guid.Parse("ab936253-1ee2-46b9-a6ce-04f3895ba6df"), Code="Triple-net lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", Description="13727", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityLeaseType Pick List
         /// </summary>
        public static List<RefFacilityLeaseType> RefFacilityLeaseTypePickList = new List<RefFacilityLeaseType> =
        {
            new RefFacilityLeaseType { Id=Guid.Parse("6fde4127-c689-4dc5-95e1-4646d49ce654"), Code="Building lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=0 },
            new RefFacilityLeaseType { Id=Guid.Parse("5908d67b-f6a8-485f-9bd3-e8cd50963241"), Code="Ground lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=0 },
            new RefFacilityLeaseType { Id=Guid.Parse("50f9cb17-828c-49ff-b2c2-253fe86a5e0f"), Code="Lease build to suit is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=0 },
            new RefFacilityLeaseType { Id=Guid.Parse("e37c8a07-6fda-4f90-ae92-57d2a4bdc429"), Code="Lease shell with significant leasehold improvements is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=0 },
            new RefFacilityLeaseType { Id=Guid.Parse("ab936253-1ee2-46b9-a6ce-04f3895ba6df"), Code="Triple-net lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=0 },
       };
   }
}
