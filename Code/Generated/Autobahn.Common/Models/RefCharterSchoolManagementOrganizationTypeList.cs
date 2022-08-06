//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCharterSchoolManagementOrganizationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCharterSchoolManagementOrganizationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCharterSchoolManagementOrganizationType"> List
         /// </summary>
        public static List<RefCharterSchoolManagementOrganizationType> RefCharterSchoolManagementOrganizationTypeList = new List<RefCharterSchoolManagementOrganizationType>
        {
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("0e75d1ef-fcdb-4fe7-9d5b-e1c78e0eef9b"), Code="CMO", Description="Charter Management Organization", Definition="A non-profit organization that operates or manages multiple charter schools (i.e., either through a contract with the charter schools or as the charter holder) linked by centralized support, operations, and oversight.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("f9593689-d029-4bcc-a510-46d3dea8af5c"), Code="EMO", Description="Education Management Organization", Definition="A for-profit entity that contracts with new or existing public school districts, charter school districts, and charter schools to manage charter schools by centralizing support, operations, and oversight.  ", SortOrder=Convert.ToDecimal("2.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("2a9153c6-1934-4093-a72d-62a660c33b13"), Code="SMFP", Description="Single Management (for-profit)", Definition="A for-profit entity that is not a CMO or EMO and that provides management services to one charter school.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("d4a05fe9-d5cf-4225-a3be-e4cf0272f640"), Code="SMNP", Description="Single Management (non-profit)", Definition="A non-profit organization that is not a CMO or EMO and that provides management services.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefCharterSchoolManagementOrganizationType Pick List
         /// </summary>
        public static List<RefCharterSchoolManagementOrganizationType> RefCharterSchoolManagementOrganizationTypePickList = new List<RefCharterSchoolManagementOrganizationType>
        {
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("0e75d1ef-fcdb-4fe7-9d5b-e1c78e0eef9b"), Code="CMO", Description="Charter Management Organization", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("f9593689-d029-4bcc-a510-46d3dea8af5c"), Code="EMO", Description="Education Management Organization", SortOrder=Convert.ToDecimal("2.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("2a9153c6-1934-4093-a72d-62a660c33b13"), Code="SMFP", Description="Single Management (for-profit)", SortOrder=Convert.ToDecimal("3.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("d4a05fe9-d5cf-4225-a3be-e4cf0272f640"), Code="SMNP", Description="Single Management (non-profit)", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
