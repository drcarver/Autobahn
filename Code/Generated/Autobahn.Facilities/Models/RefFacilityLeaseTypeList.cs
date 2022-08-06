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
        public static List<RefFacilityLeaseType> RefFacilityLeaseTypeList = new List<RefFacilityLeaseType>
        {
            new RefFacilityLeaseType { Id=Guid.Parse("3ef18902-b279-4794-a2d4-4f459cb0c203"), Code="13723", Description="Building lease", Definition="Building lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("7c154465-6b3c-4626-98b2-ab2e80e40574"), Code="13724", Description="Ground lease", Definition="Ground lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("805f84bc-652c-4b9d-b714-c9050f25a9ac"), Code="13725", Description="Lease build to suit", Definition="Lease build to suit is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("721770eb-66c3-4503-a440-5399f126b6fd"), Code="13726", Description="Lease shell with significant leasehold improvements", Definition="Lease shell with significant leasehold improvements is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("491e1c9b-f2ad-4ebf-9c04-b625f39be029"), Code="13727", Description="Triple-net lease", Definition="Triple-net lease is specified as the type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefFacilityLeaseType Pick List
         /// </summary>
        public static List<RefFacilityLeaseType> RefFacilityLeaseTypePickList = new List<RefFacilityLeaseType>
        {
            new RefFacilityLeaseType { Id=Guid.Parse("3ef18902-b279-4794-a2d4-4f459cb0c203"), Code="13723", Description="Building lease", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("7c154465-6b3c-4626-98b2-ab2e80e40574"), Code="13724", Description="Ground lease", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("805f84bc-652c-4b9d-b714-c9050f25a9ac"), Code="13725", Description="Lease build to suit", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("721770eb-66c3-4503-a440-5399f126b6fd"), Code="13726", Description="Lease shell with significant leasehold improvements", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityLeaseType { Id=Guid.Parse("491e1c9b-f2ad-4ebf-9c04-b625f39be029"), Code="13727", Description="Triple-net lease", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
